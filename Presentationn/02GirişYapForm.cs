using DataAccessLayout.Concrete;
using DataAccessLayout.Context;
using Entities.Abstract;
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
    public partial class GirişYapForm : Form
    {
        private readonly YouFitDbContext _youFitDbContext;
        private readonly KullaniciRepository _kullaniciRepository;
        public GirişYapForm()
        {
            InitializeComponent();
            _youFitDbContext = new YouFitDbContext();
            _kullaniciRepository = new KullaniciRepository(_youFitDbContext);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {

            this.Hide();
            GirişSayfa form = new GirişSayfa();
            form.Show();

        }
        YouFitDbContext db = new YouFitDbContext();
        Kullanici kullanici = new Kullanici();


        

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            var kullaniciIdTutucu = db.Kullanicis.Where(x => x.KullaniciMail == txtEmail.Text).FirstOrDefault();


            if (kullaniciIdTutucu != null)
            {
                if ( txtSifre.Text == kullaniciIdTutucu.KullaniciSifre)
                {
                    MessageBox.Show("Giriş başarılı.");



                    UyeOlForm.kullanici2 = kullaniciIdTutucu;


                    AnaPanel form = new AnaPanel();
                    form.Show();
                    this.Hide();
                }
                
                else if (txtSifre.Text != kullaniciIdTutucu.KullaniciSifre)
                    MessageBox.Show("Hatalı Şifre girdiniz. Tekrar Deneyiniz");
            }
            else
                MessageBox.Show("Boyle bir kullanıcı mail adresi bulunmamaktadır. Kayıtlı kullanıcı değilseniz önce kaydolmanız gerekmektedir");






        }

        
        private void GirişYapForm_Load(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            
        }

        private void chcSifreGöster_CheckedChanged(object sender, EventArgs e)
        {
            if (chcSifreGöster.CheckState == CheckState.Unchecked)
            {
                txtSifre.UseSystemPasswordChar = true;
              
            }
            else if (chcSifreGöster.CheckState == CheckState.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
               
            }
        }
    }
}
