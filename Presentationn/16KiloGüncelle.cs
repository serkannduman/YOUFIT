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

namespace Presentationn
{
    public partial class KiloGüncelle : Form
    {
        private readonly YouFitDbContext youFitDbContext;
        private readonly KullaniciDetayRepository _kullaniciDetayRepository;
        public KiloGüncelle()
        {
            youFitDbContext = new YouFitDbContext();
            _kullaniciDetayRepository = new KullaniciDetayRepository(youFitDbContext);
            InitializeComponent();
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
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var kullaniciDetayKontrol = youFitDbContext.KullaniciDetays.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();
            kullaniciDetayKontrol.KullaniciId = kullaniciDetayKontrol.KullaniciId;
            kullaniciDetayKontrol.KullaniciKilo = Convert.ToInt32(txtGuncelKilonuz.Text);
            kullaniciDetayKontrol.ModifiedDate = DateTime.Now;
            kullaniciDetayKontrol.KullaniciVKE = (Convert.ToInt32(txtGuncelKilonuz.Text) / Math.Pow(Convert.ToInt32(kullaniciDetayKontrol.KullaniciBoy), 2)) * 10000;
            _kullaniciDetayRepository.Update(kullaniciDetayKontrol);
        }

        private void KiloGüncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
