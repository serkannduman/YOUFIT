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
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
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

        private void btnHaftalikKiyasRapor_Click(object sender, EventArgs e)
        {

            this.Hide();
            HaftalıkKıyasRaporu form = new HaftalıkKıyasRaporu();
            form.Show();

        }

        private void btnAylikKiyasRapor_Click(object sender, EventArgs e)
        {

            this.Hide();
            AylıkKıyasRaporu form = new AylıkKıyasRaporu();
            form.Show();

        }

        private void btnHaftalikYemekCesidiRapor_Click(object sender, EventArgs e)
        {

            this.Hide();
            HaftalıkYemekÇeşitineGöreRapor form = new HaftalıkYemekÇeşitineGöreRapor();
            form.Show();

        }

        private void btnAylikYemekCesidiRapor_Click(object sender, EventArgs e)
        {

            this.Hide();
            AylıkYemekÇeşitineGöreRapor form = new AylıkYemekÇeşitineGöreRapor();
            form.Show();

        }

        private void Raporlar_Load(object sender, EventArgs e)
        {

        }
    }
}
