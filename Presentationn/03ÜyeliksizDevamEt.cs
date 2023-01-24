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
    public partial class UyeliksizDevamEt : Form
    {
        public UyeliksizDevamEt()
        {
            InitializeComponent();
        }                           


        private void btnGirisSayfasinaDon_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                GirişSayfa form = new GirişSayfa();
                form.Show();
            
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
            boy =Convert.ToDouble(txtBoy.Text);
            kilo =Convert.ToDouble(txtKilo.Text);
            yas = DateTime.Now.Year - dtpDogumTarihi.Value.Year;
            if (rdbErkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            if (rdbKadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            vke = kilo / (Math.Pow(boy, 2))*10000;
            txtVKI.Text = vke.ToString();


            if (cinsiyet == "Erkek")
            {
                if (yas < 19)
                {
                    if(vke<18)
                        lblKiloDurumu.Text = "Zayıf";
                    else if(vke>=18&&vke<24)
                        lblKiloDurumu.Text = "Normal Kilo";
                    else if (vke >= 24 && vke < 29)
                        lblKiloDurumu.Text = "Fazla Kilolu";
                    else if (vke >= 29 && vke < 34)
                        lblKiloDurumu.Text = "1.Derece Obezite";
                    else if (vke >= 34 && vke < 44)
                        lblKiloDurumu.Text = "2.Derece Obezite";
                    else if (vke >= 44 )
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



            // (Vücut ağırlığı/ boyun karesi) endeksi verir

        }

        private void UyeliksizDevamEt_Load(object sender, EventArgs e)
        {

        }
    }
}
