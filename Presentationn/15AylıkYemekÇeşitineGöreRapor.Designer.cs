namespace Presentationn
{
    partial class AylıkYemekÇeşitineGöreRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AylıkYemekÇeşitineGöreRapor));
            this.label3 = new System.Windows.Forms.Label();
            this.lblAy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.chartAylikFavoriYemek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.dtpAySec = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartAylikFavoriYemek)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(223, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ay Seçiniz :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAy
            // 
            this.lblAy.BackColor = System.Drawing.Color.Transparent;
            this.lblAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAy.Location = new System.Drawing.Point(36, 9);
            this.lblAy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAy.Name = "lblAy";
            this.lblAy.Size = new System.Drawing.Size(275, 46);
            this.lblAy.TabIndex = 37;
            this.lblAy.Text = "Ocak";
            this.lblAy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ayında En Çok tercih Ettiğiniz Yemekler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(148, 457);
            this.btnAnasayfayaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(225, 62);
            this.btnAnasayfayaDon.TabIndex = 35;
            this.btnAnasayfayaDon.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(429, 457);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(225, 62);
            this.btnCikis.TabIndex = 34;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // chartAylikFavoriYemek
            // 
            this.chartAylikFavoriYemek.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAylikFavoriYemek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAylikFavoriYemek.Legends.Add(legend1);
            this.chartAylikFavoriYemek.Location = new System.Drawing.Point(40, 137);
            this.chartAylikFavoriYemek.Margin = new System.Windows.Forms.Padding(4);
            this.chartAylikFavoriYemek.Name = "chartAylikFavoriYemek";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yemek Kategorileri";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartAylikFavoriYemek.Series.Add(series1);
            this.chartAylikFavoriYemek.Size = new System.Drawing.Size(741, 292);
            this.chartAylikFavoriYemek.TabIndex = 33;
            this.chartAylikFavoriYemek.Text = "chart1";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.Bisque;
            this.btnGoruntule.Location = new System.Drawing.Point(379, 91);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(164, 38);
            this.btnGoruntule.TabIndex = 40;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // dtpAySec
            // 
            this.dtpAySec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAySec.Location = new System.Drawing.Point(379, 62);
            this.dtpAySec.Name = "dtpAySec";
            this.dtpAySec.Size = new System.Drawing.Size(164, 26);
            this.dtpAySec.TabIndex = 41;
            // 
            // AylıkYemekÇeşitineGöreRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 506);
            this.Controls.Add(this.dtpAySec);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.chartAylikFavoriYemek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AylıkYemekÇeşitineGöreRapor";
            this.Text = "AylıkYemekÇeşitineGöreRapor";
            ((System.ComponentModel.ISupportInitialize)(this.chartAylikFavoriYemek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAylikFavoriYemek;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.DateTimePicker dtpAySec;
    }
}