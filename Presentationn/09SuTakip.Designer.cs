namespace Presentationn
{
    partial class SuTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuTakip));
            this.lblSuYuzdesi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.lblBugunTuketilenSuMiktari = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIcilenSu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIcilmesiGerekenSuMiktari = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTuketilmesiGerekenSu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuYuzdesi
            // 
            this.lblSuYuzdesi.AutoSize = true;
            this.lblSuYuzdesi.BackColor = System.Drawing.Color.Transparent;
            this.lblSuYuzdesi.Location = new System.Drawing.Point(697, 316);
            this.lblSuYuzdesi.Name = "lblSuYuzdesi";
            this.lblSuYuzdesi.Size = new System.Drawing.Size(0, 20);
            this.lblSuYuzdesi.TabIndex = 41;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Bisque;
            this.btnEkle.Location = new System.Drawing.Point(24, 213);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 59);
            this.btnEkle.TabIndex = 38;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(613, 418);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(141, 59);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(368, 418);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(145, 59);
            this.btnAnasayfayaDon.TabIndex = 37;
            this.btnAnasayfayaDon.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // lblBugunTuketilenSuMiktari
            // 
            this.lblBugunTuketilenSuMiktari.AutoSize = true;
            this.lblBugunTuketilenSuMiktari.BackColor = System.Drawing.Color.Transparent;
            this.lblBugunTuketilenSuMiktari.Location = new System.Drawing.Point(345, 290);
            this.lblBugunTuketilenSuMiktari.Name = "lblBugunTuketilenSuMiktari";
            this.lblBugunTuketilenSuMiktari.Size = new System.Drawing.Size(19, 20);
            this.lblBugunTuketilenSuMiktari.TabIndex = 35;
            this.lblBugunTuketilenSuMiktari.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bugün Tüketilen Su Miktarı (ml):";
            // 
            // txtIcilenSu
            // 
            this.txtIcilenSu.Location = new System.Drawing.Point(24, 164);
            this.txtIcilenSu.Name = "txtIcilenSu";
            this.txtIcilenSu.Size = new System.Drawing.Size(211, 26);
            this.txtIcilenSu.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Aşağıya gün içinde içtiğiniz su miktarını mililitre bazından giriniz";
            // 
            // lblIcilmesiGerekenSuMiktari
            // 
            this.lblIcilmesiGerekenSuMiktari.BackColor = System.Drawing.Color.Transparent;
            this.lblIcilmesiGerekenSuMiktari.Location = new System.Drawing.Point(544, 25);
            this.lblIcilmesiGerekenSuMiktari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIcilmesiGerekenSuMiktari.Name = "lblIcilmesiGerekenSuMiktari";
            this.lblIcilmesiGerekenSuMiktari.Size = new System.Drawing.Size(140, 25);
            this.lblIcilmesiGerekenSuMiktari.TabIndex = 30;
            this.lblIcilmesiGerekenSuMiktari.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(144, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Günlük içmeniz gereken su miktarı (ml):";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(523, 204);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "İçilen Su";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(308, 165);
            this.chart1.TabIndex = 42;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tüketmeniz Gereken Su Miktarı (ml):";
            // 
            // lblTuketilmesiGerekenSu
            // 
            this.lblTuketilmesiGerekenSu.AutoSize = true;
            this.lblTuketilmesiGerekenSu.BackColor = System.Drawing.Color.Transparent;
            this.lblTuketilmesiGerekenSu.Location = new System.Drawing.Point(346, 349);
            this.lblTuketilmesiGerekenSu.Name = "lblTuketilmesiGerekenSu";
            this.lblTuketilmesiGerekenSu.Size = new System.Drawing.Size(19, 20);
            this.lblTuketilmesiGerekenSu.TabIndex = 35;
            this.lblTuketilmesiGerekenSu.Text = "0";
            // 
            // SuTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 546);
            this.Controls.Add(this.lblSuYuzdesi);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.lblTuketilmesiGerekenSu);
            this.Controls.Add(this.lblBugunTuketilenSuMiktari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIcilenSu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIcilmesiGerekenSuMiktari);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SuTakip";
            this.Text = "SuTakip";
            this.Load += new System.EventHandler(this.SuTakip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuYuzdesi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Label lblBugunTuketilenSuMiktari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIcilenSu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIcilmesiGerekenSuMiktari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTuketilmesiGerekenSu;
    }
}