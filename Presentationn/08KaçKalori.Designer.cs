namespace Presentationn
{
    partial class KaçKalori
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaçKalori));
            this.nudPorsiyon = new System.Windows.Forms.NumericUpDown();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.lbl1PorsiyonKaloriDegeri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYemek = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).BeginInit();
            this.SuspendLayout();
            // 
            // nudPorsiyon
            // 
            this.nudPorsiyon.Location = new System.Drawing.Point(120, 122);
            this.nudPorsiyon.Name = "nudPorsiyon";
            this.nudPorsiyon.Size = new System.Drawing.Size(45, 30);
            this.nudPorsiyon.TabIndex = 27;
            this.nudPorsiyon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPorsiyon.ValueChanged += new System.EventHandler(this.nudPorsiyon_ValueChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(293, 187);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(141, 59);
            this.btnCikis.TabIndex = 25;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(127, 187);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(145, 59);
            this.btnAnasayfayaDon.TabIndex = 26;
            this.btnAnasayfayaDon.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // lbl1PorsiyonKaloriDegeri
            // 
            this.lbl1PorsiyonKaloriDegeri.AutoSize = true;
            this.lbl1PorsiyonKaloriDegeri.BackColor = System.Drawing.Color.Transparent;
            this.lbl1PorsiyonKaloriDegeri.Location = new System.Drawing.Point(410, 124);
            this.lbl1PorsiyonKaloriDegeri.Name = "lbl1PorsiyonKaloriDegeri";
            this.lbl1PorsiyonKaloriDegeri.Size = new System.Drawing.Size(24, 25);
            this.lbl1PorsiyonKaloriDegeri.TabIndex = 24;
            this.lbl1PorsiyonKaloriDegeri.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(171, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "porsiyon kalori miktarı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yemek";
            // 
            // cmbYemek
            // 
            this.cmbYemek.FormattingEnabled = true;
            this.cmbYemek.Location = new System.Drawing.Point(119, 47);
            this.cmbYemek.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmbYemek.Name = "cmbYemek";
            this.cmbYemek.Size = new System.Drawing.Size(333, 33);
            this.cmbYemek.TabIndex = 21;
            this.cmbYemek.SelectedIndexChanged += new System.EventHandler(this.cmbYemek_SelectedIndexChanged);
            // 
            // KaçKalori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 288);
            this.Controls.Add(this.nudPorsiyon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.lbl1PorsiyonKaloriDegeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbYemek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KaçKalori";
            this.Text = "KaçKalori";
            this.Load += new System.EventHandler(this.KaçKalori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPorsiyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudPorsiyon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Label lbl1PorsiyonKaloriDegeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYemek;
    }
}