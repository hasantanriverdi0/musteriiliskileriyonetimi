namespace musteriiliskileriyonetimi
{
    partial class guncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guncelle));
            this.pnl_guncelle = new System.Windows.Forms.Panel();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.txt_pozisyon = new System.Windows.Forms.TextBox();
            this.txt_is = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnl_guncelle
            // 
            this.pnl_guncelle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_guncelle.Location = new System.Drawing.Point(51, 467);
            this.pnl_guncelle.Name = "pnl_guncelle";
            this.pnl_guncelle.Size = new System.Drawing.Size(182, 41);
            this.pnl_guncelle.TabIndex = 6;
            this.pnl_guncelle.Click += new System.EventHandler(this.pnl_guncelle_Click);
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(305, 467);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(182, 41);
            this.pnl_cikis.TabIndex = 7;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click);
            // 
            // txt_pozisyon
            // 
            this.txt_pozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pozisyon.Location = new System.Drawing.Point(58, 357);
            this.txt_pozisyon.Name = "txt_pozisyon";
            this.txt_pozisyon.Size = new System.Drawing.Size(158, 24);
            this.txt_pozisyon.TabIndex = 11;
            // 
            // txt_is
            // 
            this.txt_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_is.Location = new System.Drawing.Point(58, 289);
            this.txt_is.Name = "txt_is";
            this.txt_is.Size = new System.Drawing.Size(158, 24);
            this.txt_is.TabIndex = 10;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(58, 222);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(158, 24);
            this.txt_soyad.TabIndex = 9;
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(58, 163);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(158, 24);
            this.txt_ad.TabIndex = 8;
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.txt_pozisyon);
            this.Controls.Add(this.txt_is);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.pnl_guncelle);
            this.Name = "guncelle";
            this.Text = "Müşteri İlişkileri Yönetimi";
            this.Load += new System.EventHandler(this.guncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_guncelle;
        private System.Windows.Forms.Panel pnl_cikis;
        private System.Windows.Forms.TextBox txt_pozisyon;
        private System.Windows.Forms.TextBox txt_is;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
    }
}