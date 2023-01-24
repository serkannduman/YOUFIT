using DataAccessLayout.Concrete;
using DataAccessLayout.Context;
using Entities.Concrete;
using Entities.Enums;
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
    public partial class KaloriTakip : Form
    {
        private readonly YouFitDbContext youFitDbContext;
        private readonly OgunRepository _OgunRepository;
        private readonly YenilenYemekRepository _yenilenYemekRepository;
        private readonly KullaniciDetayRepository _kullaniciDetayRepository;



        public KaloriTakip()
        {
            youFitDbContext = new YouFitDbContext();
            _OgunRepository = new OgunRepository(youFitDbContext);
            _yenilenYemekRepository = new YenilenYemekRepository(youFitDbContext);
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

        private void btnMenuyeYemekEkle_Click(object sender, EventArgs e)
        {

        }



        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double top = 0;
            for (int i = 0; i < goruntulenecekler.Count; i++)
            {
                top = top + (double)(goruntulenecekler[i].ToplamKalori);
            }

            lblToplamKaloriDegeriniz.Text = top.ToString();

            lblKalanKaloriDegeriniz.Text = (Convert.ToDouble(lblGerekenKalori.Text) - top).ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            goruntulenecekler.RemoveAt(secilenindex);

            dgvEklenenYemekler.DataSource = null;
            dgvEklenenYemekler.DataSource = goruntulenecekler;


        }
        double gerekenKalori;
        private void KaloriTakip_Load(object sender, EventArgs e)
        {
            cmbOgun.Items.Add(OgunTipi.Sabah);
            cmbOgun.Items.Add(OgunTipi.Öğlen);
            cmbOgun.Items.Add(OgunTipi.Akşam);
            cmbOgun.Items.Add(OgunTipi.Aperatif);

            var besinListe = youFitDbContext.Besinlers.ToList();
            cmbYemek.ValueMember = "BesinId";
            cmbYemek.DisplayMember = "BesinAdi";
            cmbYemek.DataSource = besinListe;

            nudPorsiyon.Increment = 0.5M;
            nudPorsiyon.DecimalPlaces = 1;


            var kullaniciDetayKontrol = youFitDbContext.KullaniciDetays.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();


            lblGuncelVKEDegeriniz.Text = kullaniciDetayKontrol.KullaniciVKE.ToString();
            double BMH;
            if (kullaniciDetayKontrol.Cinsiyet == Cinsiyet.Kadın)
            {
                BMH = (10 * (double)kullaniciDetayKontrol.KullaniciKilo) + (6.25 * (double)kullaniciDetayKontrol.KullaniciBoy) - (5 * (double)(DateTime.Now.Year - kullaniciDetayKontrol.KullaniciDogumTarihi.Value.Year)) - 161;
            }
            else
            {
                BMH = (10 * (double)kullaniciDetayKontrol.KullaniciKilo) + (6.25 * (double)kullaniciDetayKontrol.KullaniciBoy) - (5 * (double)(DateTime.Now.Year - kullaniciDetayKontrol.KullaniciDogumTarihi.Value.Year)) + 5;
            }

            gerekenKalori = BMH * 1.3;

            if (kullaniciDetayKontrol.Hedef == Hedef.KiloAl)
                lblGerekenKalori.Text = (gerekenKalori + 300).ToString();
            else if (kullaniciDetayKontrol.Hedef == Hedef.KiloVer)
                lblGerekenKalori.Text = (gerekenKalori - 300).ToString();
            else if (kullaniciDetayKontrol.Hedef == Hedef.FormunuKoru)
                lblGerekenKalori.Text = gerekenKalori.ToString();



        }


        List<YenilenYemek> goruntulenecekler = new List<YenilenYemek>();
        YenilenYemek yenilenYemekListe;
        private void btnYedikleriniEkle_Click(object sender, EventArgs e)
        {

            yenilenYemekListe = new YenilenYemek();
            yenilenYemekListe.YenilenYemekAdi = cmbYemek.SelectedItem.ToString();
            if (nudPorsiyon.Value == (decimal)0.5)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.Yarım;
            }
            if (nudPorsiyon.Value == (decimal)1)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.Bir;
            }
            if (nudPorsiyon.Value == (decimal)1.5)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.BirBuçuk;
            }
            if (nudPorsiyon.Value == (decimal)2)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.İki;
            }
            if (nudPorsiyon.Value == (decimal)2.5)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.İkiBuçuk;
            }
            if (nudPorsiyon.Value == (decimal)3)
            {
                yenilenYemekListe.Porsiyon = Porsiyon.Üç;
            }

            var KaloriTakip = youFitDbContext.Besinlers.Where(x => x.BesinAdi == yenilenYemekListe.YenilenYemekAdi).FirstOrDefault();
            yenilenYemekListe.ToplamKalori = (double)(KaloriTakip.BesinKalori * (nudPorsiyon.Value));

            goruntulenecekler.Add(yenilenYemekListe);

            dgvEklenenYemekler.DataSource = null;
            dgvEklenenYemekler.DataSource = goruntulenecekler;

            this.dgvEklenenYemekler.Columns["YenilenYemekId"].Visible = false;
            this.dgvEklenenYemekler.Columns["KategoriId"].Visible = false;
            this.dgvEklenenYemekler.Columns["OgunId"].Visible = false;
            this.dgvEklenenYemekler.Columns["Ogun"].Visible = false;
            this.dgvEklenenYemekler.Columns["CreatedDate"].Visible = false;
            this.dgvEklenenYemekler.Columns["CreatedBy"].Visible = false;
            this.dgvEklenenYemekler.Columns["ModifiedDate"].Visible = false;
            this.dgvEklenenYemekler.Columns["ModifiedBy"].Visible = false;
            this.dgvEklenenYemekler.Columns["DeletedDate"].Visible = false;
            this.dgvEklenenYemekler.Columns["DeletedBy"].Visible = false;
            this.dgvEklenenYemekler.Columns["Status"].Visible = false;


        }
        YenilenYemek yenilenYemek = new YenilenYemek();
        Ogun ogun = new Ogun();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbOgun.Text == "Sabah")
            {
                ogun.OgunTipi = OgunTipi.Sabah;

            }
            else if (cmbOgun.Text == "Öğlen")
            {
                ogun.OgunTipi = OgunTipi.Öğlen;
            }
            else if (cmbOgun.Text == "Akşam")
            {
                ogun.OgunTipi = OgunTipi.Akşam;
            }
            else if (cmbOgun.Text == "Aperatif")
            {
                ogun.OgunTipi = OgunTipi.Aperatif;
            }



            var kullaniciIdKayit = youFitDbContext.Kullanicis.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();

            ogun.KullaniciId = kullaniciIdKayit.KullaniciId;
            ogun.KayitTarihi = dtpOgunTarih.Value;
            int top = 0;
            for (int i = 0; i < goruntulenecekler.Count; i++)
            {
                top = top + (int)(goruntulenecekler[i].ToplamKalori);
            }


            ogun.ToplamKalori = top;



            _OgunRepository.Add(ogun);



            for (int i = 0; i < goruntulenecekler.Count; i++)
            {

                string a = goruntulenecekler[i].YenilenYemekAdi;

                yenilenYemek.YenilenYemekAdi = goruntulenecekler[i].YenilenYemekAdi;
                yenilenYemek.Porsiyon = goruntulenecekler[i].Porsiyon;
                yenilenYemek.ToplamKalori = goruntulenecekler[i].ToplamKalori;

                var yemekKategori = youFitDbContext.Besinlers.Where(x => x.BesinAdi == a).FirstOrDefault();

                yenilenYemek.KategoriId = yemekKategori.KategoriId;
                yenilenYemek.OgunId = ogun.OgunId;
                _yenilenYemekRepository.Add(yenilenYemek);
            }

        }
        int secilenindex;

        private void dgvEklenenYemekler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            secilenindex = dgvEklenenYemekler.CurrentCell.RowIndex;
        }

        private void dgvEklenenYemekler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
