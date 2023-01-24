namespace Presentationn
{
    partial class GirişSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.btnUyeOlmadanDevamEt = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(545, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "YOUFIT ile kontrol sizde !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCikis.ForeColor = System.Drawing.Color.Bisque;
            this.btnCikis.Location = new System.Drawing.Point(656, 421);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(210, 61);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUyeOl.ForeColor = System.Drawing.Color.Bisque;
            this.btnUyeOl.Location = new System.Drawing.Point(438, 421);
            this.btnUyeOl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(210, 61);
            this.btnUyeOl.TabIndex = 8;
            this.btnUyeOl.Text = "Üye Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.btnUyeOl_Click);
            // 
            // btnUyeOlmadanDevamEt
            // 
            this.btnUyeOlmadanDevamEt.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUyeOlmadanDevamEt.ForeColor = System.Drawing.Color.Bisque;
            this.btnUyeOlmadanDevamEt.Location = new System.Drawing.Point(4, 421);
            this.btnUyeOlmadanDevamEt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUyeOlmadanDevamEt.Name = "btnUyeOlmadanDevamEt";
            this.btnUyeOlmadanDevamEt.Size = new System.Drawing.Size(210, 61);
            this.btnUyeOlmadanDevamEt.TabIndex = 9;
            this.btnUyeOlmadanDevamEt.Text = "Üye Olmadan Devam Et";
            this.btnUyeOlmadanDevamEt.UseVisualStyleBackColor = false;
            this.btnUyeOlmadanDevamEt.Click += new System.EventHandler(this.btnUyeOlmadanDevamEt_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGirisYap.ForeColor = System.Drawing.Color.Bisque;
            this.btnGirisYap.Location = new System.Drawing.Point(221, 421);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(210, 61);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // GirişSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUyeOl);
            this.Controls.Add(this.btnUyeOlmadanDevamEt);
            this.Controls.Add(this.btnGirisYap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GirişSayfa";
            this.Text = "GirişSayfa";
            this.Load += new System.EventHandler(this.GirişSayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Button btnUyeOlmadanDevamEt;
        private System.Windows.Forms.Button btnGirisYap;
    }
}