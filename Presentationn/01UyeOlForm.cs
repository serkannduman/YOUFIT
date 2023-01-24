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
    public partial class UyeOlForm : Form
    {
        private readonly YouFitDbContext youFitDbContext;
        private readonly KullaniciRepository _kullaniciRepository;




        public UyeOlForm()
        {
            InitializeComponent();
            youFitDbContext = new YouFitDbContext();
            _kullaniciRepository = new KullaniciRepository(youFitDbContext);


        }


        private void btnVazgec_Click(object sender, EventArgs e)
        {

            this.Hide();
            GirişSayfa form = new GirişSayfa();
            form.Show();

        }
        YouFitDbContext db = new YouFitDbContext();
        Kullanici kullanici = new Kullanici();



        public static Kullanici kullanici2;

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            
            var kullaniciMailKontrol = db.Kullanicis.Where(x => x.KullaniciMail == txtEmail.Text).FirstOrDefault();

            char[] dizi;
            dizi = txtSifre.Text.ToCharArray();
            int buyukHarfSayac = 0;
            int kucukHarfSayac = 0;
            int karakterSayac = 0;

            for (int i = 0; i < dizi.Length; i++)
            {

                if (Convert.ToInt32(dizi[i]) <= 90 && Convert.ToInt16(dizi[i]) >= 65)
                    buyukHarfSayac++;
                else if (Convert.ToInt32(dizi[i]) <= 122 && Convert.ToInt16(dizi[i]) >= 97)
                    kucukHarfSayac++;
                else if (Convert.ToInt32(dizi[i]) <= 47 && Convert.ToInt16(dizi[i]) >= 33)
                    karakterSayac++;
            }

            if (buyukHarfSayac >= 2 && kucukHarfSayac >= 3 && karakterSayac >= 2 && dizi.Length >= 8)
            {
                if (txtSifre.Text == txtSifreTekrar.Text && kullaniciMailKontrol == null && txtEmail.Text!= String.Empty)
                {
                    kullanici.KullaniciMail = txtEmail.Text;
                    kullanici.KullaniciSifre = txtSifre.Text;

                    kullanici.KullaniciAdi = txtAd.Text;
                    kullanici.KullaniciSoyadi = txtSoyad.Text;
                    char[] dizi2;
                    dizi2 = txtTelefon.Text.ToCharArray();
                    int sayac = 0;

                    for (int i = 0; i < dizi2.Length; i++)
                    {
                        if (Convert.ToInt32(dizi2[i]) >= 48 && Convert.ToInt32(dizi2[i]) <= 57)
                        {
                            sayac++;
                        }
                    }
                    
                    if (sayac==11 && dizi2.Length==11)
                    {
                        kullanici.KullaniciTelefon = txtTelefon.Text;
                        if (chkOnaylama.Checked)
                        {

                            MessageBox.Show("Kayıt başarılı");
                            _kullaniciRepository.Add(kullanici);
                            var kullaniciIdTutucu = db.Kullanicis.Where(x => x.KullaniciMail == txtEmail.Text).FirstOrDefault();

                            kullanici2 = kullaniciIdTutucu;

                            UyeBilgiKayıt form = new UyeBilgiKayıt();
                            form.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı sözleşmesini kabul etmelisiniz.");
                        }
                    }
                   else
                        MessageBox.Show("Girdiğiniz telefon bilgisi geçersizdir. Lütfen 11 haneli ve rakamlardan oluşan telefon numaranızı giriniz.");

                   
                }
                else if (txtSifre.Text == txtSifreTekrar.Text && kullaniciMailKontrol != null && txtEmail.Text != String.Empty)
                    MessageBox.Show("Bu email adresi sistemde bulunmaktadır. Lütfen başka bir email adresi giriniz.");
                else if(txtSifre.Text != txtSifreTekrar.Text && kullaniciMailKontrol == null && txtEmail.Text != String.Empty)
                    MessageBox.Show("Girilen şifreler uyuşmamaktadır.Lütfen tekrar giriniz.");
                else if (txtSifre.Text==txtSifreTekrar.Text && kullaniciMailKontrol==null && txtEmail.Text==String.Empty)
                {
                    MessageBox.Show("Mail bilginiz boş geçilemez.");
                }
            }
            else
                MessageBox.Show("Şifreniz an az 2 Büyük Harf , en az 3 küçük harf ve an az2 karakter içermelidir. ayrıca şifre uzunluğu en az 8 karekter olmalıdır");

          

         
        }

        private void UyeOlForm_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            txtSifreTekrar.UseSystemPasswordChar = true;
        }

        private void chcSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSifreGöster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifreTekrar.UseSystemPasswordChar = true;
            }
            else if (chcSifreGöster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifreTekrar.UseSystemPasswordChar = false;
            }
        }

        private void chkOnaylama_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
