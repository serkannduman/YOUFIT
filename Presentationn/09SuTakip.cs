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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentationn
{
    public partial class SuTakip : Form
    {
        private readonly YouFitDbContext _youFitDbContext;
        private readonly KullaniciDetayRepository _kullaniciDetayRepository;
        private readonly IcilenSuRepository _icilenSuRepository;
        public SuTakip()
        {
            InitializeComponent();
            _youFitDbContext = new YouFitDbContext();
            _kullaniciDetayRepository = new KullaniciDetayRepository(_youFitDbContext);
            _icilenSuRepository = new IcilenSuRepository(_youFitDbContext);

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
        IcilenSu icilenSu = new IcilenSu();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            var suIcinKisiTakip = _youFitDbContext.KullaniciDetays.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();

            icilenSu.KullaniciId = suIcinKisiTakip.KullaniciId;

            icilenSu.IcilenSuMiktari = Convert.ToInt32(txtIcilenSu.Text);

            _icilenSuRepository.Add(icilenSu);


            lblBugunTuketilenSuMiktari.Text=(Convert.ToInt32(txtIcilenSu.Text)+Convert.ToInt32(lblBugunTuketilenSuMiktari.Text)).ToString();

            lblTuketilmesiGerekenSu.Text = ((suIcinKisiTakip.KullaniciKilo * 35) - Convert.ToInt32(lblBugunTuketilenSuMiktari.Text)).ToString();
            txtIcilenSu.Clear();



            var suBilgisi=_youFitDbContext.IcilenSus.Where(x=>x.KullaniciId==UyeOlForm.kullanici2.KullaniciId).GroupBy(x => x.KullaniciId).Select(x => new
            {
                KullaniciId = x.Key,
                IcilenSu = x.Sum(y => y.IcilenSuMiktari)

            }).FirstOrDefault();




            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }



            chart1.Series["İçilen Su"].Points.AddXY("İçilen Su",suBilgisi.IcilenSu);
            chart1.Series["İçilen Su"].Points.AddXY("İçilmesi Gereken Su",((int)(suIcinKisiTakip.KullaniciKilo * 35)) - (int)(suBilgisi.IcilenSu));


            double a =Math.Round(((double)(suBilgisi.IcilenSu) / ((double)suIcinKisiTakip.KullaniciKilo * 35) * 100),1) ;

            lblSuYuzdesi.Text = "%" +a.ToString();

        }


        double icilenSuBilgisi;
        private void SuTakip_Load(object sender, EventArgs e)
        {
            var icilenSuTakip = _youFitDbContext.IcilenSus.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId && x.CreatedDate.Day == DateTime.Now.Day).GroupBy(x => x.KullaniciId).Select(x => new
            {
                KullaniciId = x.Key,
                ToplamSuMiktari = x.Sum(y => y.IcilenSuMiktari)
            }).FirstOrDefault();

            

            var suIcinKisiTakip = _youFitDbContext.KullaniciDetays.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();

            if(icilenSuTakip != null)
                lblBugunTuketilenSuMiktari.Text = icilenSuTakip.ToplamSuMiktari.ToString();
            else
                lblBugunTuketilenSuMiktari.Text = "0";



            lblIcilmesiGerekenSuMiktari.Text = (suIcinKisiTakip.KullaniciKilo * 35).ToString();
            lblTuketilmesiGerekenSu.Text = ((suIcinKisiTakip.KullaniciKilo * 35) - Convert.ToInt32(lblBugunTuketilenSuMiktari.Text)).ToString();

            var suBilgisi = _youFitDbContext.IcilenSus.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).GroupBy(x => x.KullaniciId).Select(x => new
            {
                KullaniciId = x.Key,
                IcilenSu = x.Sum(y => y.IcilenSuMiktari)

            }).FirstOrDefault();

            if (suBilgisi == null)
                icilenSuBilgisi = 0;
            else
                icilenSuBilgisi = suBilgisi.IcilenSu;
            



            chart1.Series["İçilen Su"].IsValueShownAsLabel = true;
            

            chart1.BackColor = Color.YellowGreen;

            chart1.Series["İçilen Su"].Points.AddXY("İçilen Su", icilenSuBilgisi);
            chart1.Series["İçilen Su"].Points.AddXY("İçilmesi Gereken Su", ((int)(suIcinKisiTakip.KullaniciKilo * 35)) - (int)(icilenSuBilgisi));


            double a = Math.Round(((double)(icilenSuBilgisi) / ((double)suIcinKisiTakip.KullaniciKilo * 35) * 100), 1);

            lblSuYuzdesi.Text = "%" + a.ToString();
        }

        
    }
}
