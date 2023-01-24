namespace Presentation
{
    partial class HaftalıkYemekÇeşitineGöreRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HaftalıkYemekÇeşitineGöreRapor));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnasayfayaDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.chartHaftalikFavoriYemek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartHaftalikFavoriYemek)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 64);
            this.label2.TabIndex = 27;
            this.label2.Text = "Bu Hafta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 64);
            this.label1.TabIndex = 26;
            this.label1.Text = "En Çok tercih Ettiğiniz Yemekler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAnasayfayaDon
            // 
            this.btnAnasayfayaDon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAnasayfayaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfayaDon.ForeColor = System.Drawing.Color.Bisque;
            this.btnAnasayfayaDon.Location = new System.Drawing.Point(98, 486);
            this.btnAnasayfayaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnasayfayaDon.Name = "btnAnasayfayaDon";
            this.btnAnasayfayaDon.Size = new System.Drawing.Size(225, 62);
            this.btnAnasayfayaDon.TabIndex = 25;
            this.btnAnasayfayaDon.Text = "Anasayfaya Dön";
            this.btnAnasayfayaDon.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(379, 486);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(225, 62);
            this.btnCikis.TabIndex = 24;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            // 
            // chartHaftalikFavoriYemek
            // 
            this.chartHaftalikFavoriYemek.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartHaftalikFavoriYemek.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHaftalikFavoriYemek.Legends.Add(legend1);
            this.chartHaftalikFavoriYemek.Location = new System.Drawing.Point(70, 138);
            this.chartHaftalikFavoriYemek.Margin = new System.Windows.Forms.Padding(4);
            this.chartHaftalikFavoriYemek.Name = "chartHaftalikFavoriYemek";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yemekler";
            this.chartHaftalikFavoriYemek.Series.Add(series1);
            this.chartHaftalikFavoriYemek.Size = new System.Drawing.Size(737, 305);
            this.chartHaftalikFavoriYemek.TabIndex = 23;
            this.chartHaftalikFavoriYemek.Text = "chart1";
            // 
            // HaftalıkYemekÇeşitineGöreRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnasayfayaDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.chartHaftalikFavoriYemek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HaftalıkYemekÇeşitineGöreRapor";
            this.Text = "HaftalıkYemekÇeşitineGöreRapor";
            ((System.ComponentModel.ISupportInitialize)(this.chartHaftalikFavoriYemek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnasayfayaDon;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHaftalikFavoriYemek;
    }
}