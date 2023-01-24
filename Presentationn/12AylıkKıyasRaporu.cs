using DataAccessLayout.Concrete;
using DataAccessLayout.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentationn
{
    public partial class AylıkKıyasRaporu : Form
    {
        private readonly YouFitDbContext _youFitDbContext;
       
        public AylıkKıyasRaporu()
        {
            InitializeComponent();
            _youFitDbContext = new YouFitDbContext();
            
        }


        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {

            this.Hide();
            AnaPanel form = new AnaPanel();
            form.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void AylıkKıyasRaporu_Load(object sender, EventArgs e)
        {

        }
        public string gunler;
        double kalori;
        double ortalamaKalori;
        
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            DateTime trh = new DateTime(dtpAySec.Value.Year, dtpAySec.Value.Month, 1);

            DateTime trh2 = trh.AddMonths(1).AddDays(-1);
            


            for (int i = 0; i < trh2.Day; i++)
            {

                gunler = ((trh.Day+i).ToString() + "." + trh.Month.ToString());

                var kisiKaloriBilgisi = _youFitDbContext.Oguns.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId && x.KayitTarihi.Month==trh.Month&& x.KayitTarihi.Day == (trh.Day+i)).GroupBy(x => x.KullaniciId).Select(x => new
                {
                    KullaniciId = x.Key,
                    ToplamKalori = x.Sum(y => y.ToplamKalori)

                }).FirstOrDefault();
               
                if (kisiKaloriBilgisi!=null)
                    kalori = kisiKaloriBilgisi.ToplamKalori;
                else
                    kalori = 0;

                var ortalamaKaloriBilgisi = _youFitDbContext.Oguns.Where(x => x.KullaniciId != UyeOlForm.kullanici2.KullaniciId &&x.KayitTarihi.Month==trh.Month&& x.KayitTarihi.Day == (trh.Day+i)).GroupBy(x => x.KullaniciId).Select(x => new
                {
                    KullaniciId = x.Key,
                    ToplamKalori = x.Sum(y => y.ToplamKalori),

                }).ToList();

                double top = 0;
                double ort;
                foreach (var item in ortalamaKaloriBilgisi)
                {
                    top = item.ToplamKalori + top;
                }
                ort = top / ortalamaKaloriBilgisi.Count;
                if (double.IsNaN(ort))
                    ort = 0;


                ortalamaKalori = ort;


                chartAylikKiyas.Series["Aldığınız Kalori"].Points.AddXY(gunler, kalori);


                chartAylikKiyas.Series["Diğer Katılımcıların Ortalaması"].Points.AddXY(gunler, ortalamaKalori);

                chartAylikKiyas.Series["Aldığınız Kalori"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
               

                chartAylikKiyas.Series["Aldığınız Kalori"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                
            }
                           
               

           


               
            

        }
    }
}
