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
    public partial class GirişSayfa : Form
    {
        public GirişSayfa()
        {
            InitializeComponent();
        }

                                 
              

        private void btnUyeOlmadanDevamEt_Click(object sender, EventArgs e)
        {
            

                UyeliksizDevamEt form = new UyeliksizDevamEt();
                form.Show();
                this.Hide();
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                GirişYapForm form = new GirişYapForm();
                form.Show();
            
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                UyeOlForm form = new UyeOlForm();
                form.Show();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void GirişSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
