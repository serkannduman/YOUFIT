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

namespace Presentationn
{
    public partial class AylıkYemekÇeşitineGöreRapor : Form
    {


        private readonly YouFitDbContext _youFitDbContext;
        public AylıkYemekÇeşitineGöreRapor()
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
        
       
        private void btnGoruntule_Click(object sender, EventArgs e)
        {

            DateTime trh = new DateTime(dtpAySec.Value.Year, dtpAySec.Value.Month, 1);


            List<YenilenYemek> yemekKategori2 = new List<YenilenYemek>();


            var ogunBilgisi = _youFitDbContext.Oguns.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId && x.KayitTarihi.Month == trh.Month).ToList();

            for (int j = 0; j < ogunBilgisi.Count; j++)
            {

                int a = ogunBilgisi[j].OgunId;


                var yemekKategori = _youFitDbContext.YenilenYemeks.Where(x => x.OgunId == a).ToList();


                yemekKategori2 = yemekKategori2.Concat(yemekKategori).ToList();
            }

            var yemekKategoriBilgisi = yemekKategori2.GroupBy(x => x.KategoriId).Select(x => new
            {
                katid = x.Key,
                countd = x.ToList().Count,
            }).OrderByDescending(x=>x.countd).ToList();

            for (int i = 0; i < 3; i++)
            {

                int a = yemekKategoriBilgisi[i].katid;
                var charticin = _youFitDbContext.BesinKategorileris.Where(x => x.KategoriId == a).FirstOrDefault();

                chartAylikFavoriYemek.Series["Yemek Kategorileri"].Points.AddXY(charticin.KategoriAdi, yemekKategoriBilgisi[i].countd);
            }


            chartAylikFavoriYemek.Series["Yemek Kategorileri"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

















        }
    }
}
