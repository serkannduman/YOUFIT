namespace Presentationn
{
    partial class AylıkKıyasRaporu
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AylıkKıyasRaporu));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartAylikKiyas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpAySec = new System.Windows.Forms.DateTimePicker();
            this.btnGoruntule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAylikKiyas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(166, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ay Seçiniz :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(100, 387);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(169, 59);
            this.btnAnasayfayaDon.TabIndex = 37;
            this.btnAnasayfayaDon.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            this.btnAnasayfayaDon.Click += new System.EventHandler(this.btnAnasayfayaDon_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(311, 387);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(169, 59);
            this.btnCikis.TabIndex = 36;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 52);
            this.label1.TabIndex = 35;
            this.label1.Text = "Diğer Katılımcıların Seçtiğiniz Aydaki Kalori Alımlarıyla Kendinizi Kıyaslayın";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartAylikKiyas
            // 
            this.chartAylikKiyas.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartAylikKiyas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAylikKiyas.Legends.Add(legend1);
            this.chartAylikKiyas.Location = new System.Drawing.Point(11, 144);
            this.chartAylikKiyas.Margin = new System.Windows.Forms.Padding(2);
            this.chartAylikKiyas.Name = "chartAylikKiyas";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Aldığınız Kalori";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Diğer Katılımcıların Ortalaması";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chartAylikKiyas.Series.Add(series1);
            this.chartAylikKiyas.Series.Add(series2);
            this.chartAylikKiyas.Size = new System.Drawing.Size(573, 219);
            this.chartAylikKiyas.TabIndex = 34;
            this.chartAylikKiyas.Text = "Diğer Katılımcıların Aylık Kalori Alımlarıyla Kendinizi Kıyaslayın";
            // 
            // dtpAySec
            // 
            this.dtpAySec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAySec.Location = new System.Drawing.Point(286, 64);
            this.dtpAySec.Name = "dtpAySec";
            this.dtpAySec.Size = new System.Drawing.Size(160, 26);
            this.dtpAySec.TabIndex = 40;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.ForeColor = System.Drawing.Color.Bisque;
            this.btnGoruntule.Location = new System.Drawing.Point(336, 100);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(169, 39);
            this.btnGoruntule.TabIndex = 41;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // AylıkKıyasRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 502);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.dtpAySec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartAylikKiyas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AylıkKıyasRaporu";
            this.Text = "AylıkKıyasRaporu";
            this.Load += new System.EventHandler(this.AylıkKıyasRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAylikKiyas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAylikKiyas;
        private System.Windows.Forms.DateTimePicker dtpAySec;
        private System.Windows.Forms.Button btnGoruntule;
    }
}