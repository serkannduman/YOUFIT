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
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentationn
{
    public partial class UyeBilgiKayıt : Form
    {



        private readonly YouFitDbContext youFitDbContext;
        private readonly KullaniciDetayRepository _kullaniciDetayRepository;


        public UyeBilgiKayıt()
        {
            InitializeComponent();

            youFitDbContext = new YouFitDbContext();
            _kullaniciDetayRepository = new KullaniciDetayRepository(youFitDbContext);

        }


        YouFitDbContext db = new YouFitDbContext();
        KullaniciDetay kullaniciDetay = new KullaniciDetay();


        
        



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                UyeOlForm frm = new UyeOlForm();

                var kullaniciDetayKontrol = db.Kullanicis.Where(x => x.KullaniciId == UyeOlForm.kullanici2.KullaniciId).FirstOrDefault();

                kullaniciDetay.KullaniciId = kullaniciDetayKontrol.KullaniciId;
                kullaniciDetay.KullaniciDogumTarihi = dtpDogumTarihi.Value;


                int kullaniciYas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
                if (kullaniciYas < 19)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik1;
                }
                if (kullaniciYas >= 19 && kullaniciYas < 25)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik2;
                }
                if (kullaniciYas >= 25 && kullaniciYas < 35)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik3;
                }
                if (kullaniciYas >= 35 && kullaniciYas < 45)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik4;
                }
                if (kullaniciYas >= 45 && kullaniciYas < 55)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik5;
                }
                if (kullaniciYas >= 55 && kullaniciYas < 65)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik6;
                }
                if (kullaniciYas >= 65)
                {
                    kullaniciDetay.YasAraligi = YasAraligi.Aralik7;
                }


                kullaniciDetay.KullaniciBoy = Convert.ToInt32(txtBoy.Text);

                try
                {
                    kullaniciDetay.KullaniciKilo = Convert.ToInt32(txtKilo.Text);


                    double vke = (Convert.ToInt32(txtKilo.Text) / Math.Pow(Convert.ToInt32(txtBoy.Text), 2)) * 10000;
                    kullaniciDetay.KullaniciVKE = vke;




                    if (rdbKadin.Checked)
                    {
                        kullaniciDetay.Cinsiyet = Cinsiyet.Kadın;

                        if (kullaniciYas < 19)
                        {
                            if (vke < 17)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 17 && vke < 23)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 23 && vke < 28)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 28 && vke < 33)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 33 && vke < 43)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 43)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 19 && kullaniciYas < 25)
                        {
                            if (vke < 18)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 18 && vke < 24)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 24 && vke < 29)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 29 && vke < 34)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 34 && vke < 44)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 44)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 25 && kullaniciYas < 35)
                        {
                            if (vke < 19)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 19 && vke < 25)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 25 && vke < 30)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 30 && vke < 35)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 35 && vke < 45)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 45)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 35 && kullaniciYas < 45)
                        {
                            if (vke < 20)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 20 && vke < 26)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 26 && vke < 31)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 31 && vke < 36)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 36 && vke < 46)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 46)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 45 && kullaniciYas < 55)
                        {
                            if (vke < 21)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 21 && vke < 27)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 27 && vke < 32)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 32 && vke < 37)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 37 && vke < 47)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 47)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 55 && kullaniciYas < 65)
                        {
                            if (vke < 22)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }

                            else if (vke >= 22 && vke < 28)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 28 && vke < 33)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 33 && vke < 38)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 38 && vke < 48)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 48)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 65)
                        {
                            if (vke < 23)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 23 && vke < 29)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 29 && vke < 34)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 34 && vke < 39)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 39 && vke < 49)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 49)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                    }


                    if (rdbErkek.Checked)
                    {
                        kullaniciDetay.Cinsiyet = Cinsiyet.Erkek;
                        if (kullaniciYas < 19)
                        {
                            if (vke < 18)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 18 && vke < 24)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 24 && vke < 29)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 29 && vke < 34)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 34 && vke < 44)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 44)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 19 && kullaniciYas < 25)
                        {
                            if (vke < 19)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 19 && vke < 25)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 25 && vke < 30)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 30 && vke < 35)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 35 && vke < 45)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 45)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 25 && kullaniciYas < 35)
                        {
                            if (vke < 20)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 20 && vke < 26)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 26 && vke < 31)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 31 && vke < 36)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 36 && vke < 46)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 46)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 35 && kullaniciYas < 45)
                        {
                            if (vke < 21)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 21 && vke < 27)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 27 && vke < 32)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 32 && vke < 37)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 37 && vke < 47)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 47)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 45 && kullaniciYas < 55)
                        {
                            if (vke < 22)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 22 && vke < 28)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 28 && vke < 33)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 33 && vke < 38)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 38 && vke < 48)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 48)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 55 && kullaniciYas < 65)
                        {
                            if (vke < 23)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 23 && vke < 29)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 29 && vke < 34)
                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 34 && vke < 39)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 39 && vke < 49)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 49)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                        else if (kullaniciYas >= 65)
                        {
                            if (vke < 24)
                            {
                                kullaniciDetay.Obezite = Obezite.Zayıf;
                            }
                            else if (vke >= 24 && vke < 30)
                            {
                                kullaniciDetay.Obezite = Obezite.NormalKilolu;
                            }
                            else if (vke >= 30 && vke < 35)

                            {
                                kullaniciDetay.Obezite = Obezite.FazlaKilolu;
                            }
                            else if (vke >= 35 && vke < 40)
                            {
                                kullaniciDetay.Obezite = Obezite.BirinciDereceObezite;
                            }
                            else if (vke >= 40 && vke < 50)
                            {
                                kullaniciDetay.Obezite = Obezite.İkinciDereceObezite;
                            }
                            else if (vke >= 50)
                            {
                                kullaniciDetay.Obezite = Obezite.ÜçüncüDereceObezite;
                            }
                        }
                    }

                    if (rdbKiloAl.Checked)
                    {
                        kullaniciDetay.Hedef = Hedef.KiloAl;
                    }
                    else if (rdbKiloVer.Checked)
                        kullaniciDetay.Hedef = Hedef.KiloVer;
                    else if (rdbFormunuKoru.Checked)
                        kullaniciDetay.Hedef = Hedef.FormunuKoru;


                    _kullaniciDetayRepository.Add(kullaniciDetay);


                    GirişYapForm form = new GirişYapForm();
                    form.Show();
                    this.Hide();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Çok büyük bir değer girdiniz.Lütfen sayısal değerde Kilo bilgisi giriniz");

                }
                catch(System.Exception)
                {
                    MessageBox.Show("Lütfen sıfırdan farklı ve sayısal değerde Kilo bilgisi giriniz");
                }

               
            }
            
            catch (OverflowException)
            {
                MessageBox.Show("Çok büyük bir değer girdiniz.Lütfen sıfırdan farklı ve sayısal değerde Boy bilgisi giriniz");
            }
            catch(System.Exception )
            {
                MessageBox.Show("Lütfen sıfırdan farklı ve sayısal değerde Boy bilgisi giriniz");
            }

            

            
        }

        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {


            GirişSayfa form = new GirişSayfa();
            form.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
        double boy;
        double kilo;
        int yas;
        string cinsiyet;
        double vke;


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            if (rdbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            if (rdbKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            vke = kilo / (Math.Pow(boy, 2)) * 10000;
            txtVKI.Text = vke.ToString();


            if (cinsiyet == "Erkek")
            {
                if (yas < 19)
                {
                    if (vke < 18)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 18 && vke < 24)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 24 && vke < 29)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 29 && vke < 34)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 34 && vke < 44)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 44)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 19 && yas < 25)
                {
                    if (vke < 19)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 19 && vke < 25)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 25 && vke < 30)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 30 && vke < 35)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 35 && vke < 45)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 45)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 25 && yas < 35)
                {
                    if (vke < 20)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 20 && vke < 26)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 26 && vke < 31)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 31 && vke < 36)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 36 && vke < 46)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 46)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 35 && yas < 45)
                {
                    if (vke < 21)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 21 && vke < 27)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 27 && vke < 32)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 32 && vke < 37)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 37 && vke < 47)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 47)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 45 && yas < 55)
                {
                    if (vke < 22)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 22 && vke < 28)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 28 && vke < 33)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 33 && vke < 38)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 38 && vke < 48)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 48)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 55 && yas < 65)
                {
                    if (vke < 23)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 23 && vke < 29)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 29 && vke < 34)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 34 && vke < 39)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 39 && vke < 49)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 49)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 65)
                {
                    if (vke < 24)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 24 && vke < 30)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 30 && vke < 35)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 35 && vke < 40)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 40 && vke < 50)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 50)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }

            }

            if (cinsiyet == "Kadın")
            {
                if (yas < 19)
                {
                    if (vke < 17)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 17 && vke < 23)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 23 && vke < 28)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 28 && vke < 33)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 33 && vke < 43)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 43)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 19 && yas < 25)
                {
                    if (vke < 18)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 18 && vke < 24)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 24 && vke < 29)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 29 && vke < 34)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 34 && vke < 44)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 44)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 25 && yas < 35)
                {
                    if (vke < 19)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 19 && vke < 25)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 25 && vke < 30)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 30 && vke < 35)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 35 && vke < 45)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 45)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 35 && yas < 45)
                {
                    if (vke < 20)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 20 && vke < 26)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 26 && vke < 31)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 31 && vke < 36)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 36 && vke < 46)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 46)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 45 && yas < 55)
                {
                    if (vke < 21)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 21 && vke < 27)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 27 && vke < 32)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 32 && vke < 37)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 37 && vke < 47)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 47)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 55 && yas < 65)
                {
                    if (vke < 22)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 22 && vke < 28)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 28 && vke < 33)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 33 && vke < 38)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 38 && vke < 48)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 48)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
                else if (yas >= 65)
                {
                    if (vke < 23)
                        lblKiloDurumu.Text = "Zayıf";
                    else if (vke >= 23 && vke < 29)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 29 && vke < 34)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 34 && vke < 39)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 39 && vke < 49)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 49)
                        lblKiloDurumu.Text = "3.Derece Obezite";
                }
            }
        }

        private void UyeBilgiKayıt_Load(object sender, EventArgs e)
        {

        }

        private void UyeBilgiKayıt_Load_1(object sender, EventArgs e)
        {

        }
    }
}
