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
    public partial class AnaPanel : Form
    {
        public AnaPanel()
        {
            InitializeComponent();
        }
                                                                       
                             
        private void btnAnasayfayaDon_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                GirişSayfa form = new GirişSayfa();
                form.Show();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            
        }

        private void tsmKaloriTakip_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                KaloriTakip form = new KaloriTakip();
                form.Show();
            
        }

        private void tsmKacKalori_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                KaçKalori form = new KaçKalori();
                form.Show();
            
        }

        private void tsmSuTakip_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                SuTakip form = new SuTakip();
                form.Show();
            
        }

        private void tsmRaporlar_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                Raporlar form = new Raporlar();
                form.Show();
            
        }

        private void tsmUzmanaSor_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                UzmanaSor form = new UzmanaSor();
                form.Show();
            
        }

        private void tsmKiloGuncelle_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                KiloGüncelle form = new KiloGüncelle();
                form.Show();
            
        }

        private void AnaPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
