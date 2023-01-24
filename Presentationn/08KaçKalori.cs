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
    public partial class KaçKalori : Form
    {
        private readonly YouFitDbContext _youFitDbContext;
        private readonly BesinlerRepository _besinlerRepository;
        public KaçKalori()
        {
            InitializeComponent();
            _youFitDbContext = new YouFitDbContext();
            _besinlerRepository = new BesinlerRepository(_youFitDbContext);
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

        private void KaçKalori_Load(object sender, EventArgs e)
        {
            var besinListe = _youFitDbContext.Besinlers.ToList();
            cmbYemek.ValueMember = "BesinKalori";
            cmbYemek.DisplayMember = "BesinAdi";
            cmbYemek.DataSource = besinListe;
            
            lbl1PorsiyonKaloriDegeri.Text = " ";
        }

        private void cmbYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal sayi = nudPorsiyon.Value;
            int sayi2 = Convert.ToInt32(cmbYemek.SelectedValue);
            lbl1PorsiyonKaloriDegeri.Text = (sayi * sayi2).ToString();
            nudPorsiyon.Value = 1;

        }

        private void nudPorsiyon_ValueChanged(object sender, EventArgs e)
        {
            decimal sayi = nudPorsiyon.Value;
            int sayi2 = Convert.ToInt32(cmbYemek.SelectedValue);
            lbl1PorsiyonKaloriDegeri.Text = (sayi * sayi2).ToString();
        }
    }
}
