using DataAccessLayout.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationn
{
    public partial class HaftalıkKıyasRaporu : Form
    {

        private readonly YouFitDbContext _youFitDbContext;
        public HaftalıkKıyasRaporu()
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
        double kalori;
        double ortalamaKalori;
        private void HaftalıkKıyasRaporu_Load(object sender, EventArgs e)
        {

            DateTime trh = DateTime.Now;
            


            for (int i = 0; i < 7; i++)
            {
                string gunler = trh.AddDays(-6+i).ToString("dddd");
                

                   var kisiKaloriBilgisi = _youFitDbContext.Oguns.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId &&x.KayitTarihi.Day==(trh.Day-6+i)).GroupBy(x => x.KullaniciId).Select(x => new
                    {
                        KullaniciId = x.Key,
                        ToplamKalori = x.Sum(y => y.ToplamKalori)

                    }).FirstOrDefault();

                   if (kisiKaloriBilgisi != null)
                       kalori = kisiKaloriBilgisi.ToplamKalori;
                    else
                        kalori = 0;

                    var ortalamaKaloriBilgisi = _youFitDbContext.Oguns.Where(x => x.KullaniciId != UyeOlForm.kullanici2.KullaniciId && x.KayitTarihi.Day== (trh.Day - 6 + i)).GroupBy(x => x.KullaniciId).Select(x => new
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


                chartHaftalikKiyasRaporu.Series["Aldığınız Kalori"].Points.AddXY(gunler, kalori);


                chartHaftalikKiyasRaporu.Series["Diğer Katılımcıların Ortalaması"].Points.AddXY(gunler, ortalamaKalori);

                chartHaftalikKiyasRaporu.Series["Aldığınız Kalori"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                

                chartHaftalikKiyasRaporu.Series["Aldığınız Kalori"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
                



            }


        }
    }
}
