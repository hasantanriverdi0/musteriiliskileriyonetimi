namespace musteriiliskileriyonetimi
{
    partial class ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekle));
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_is = new System.Windows.Forms.TextBox();
            this.txt_pozisyon = new System.Windows.Forms.TextBox();
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_ad
            // 
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(56, 164);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(158, 24);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyad.Location = new System.Drawing.Point(56, 223);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(158, 24);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_is
            // 
            this.txt_is.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_is.Location = new System.Drawing.Point(56, 290);
            this.txt_is.Name = "txt_is";
            this.txt_is.Size = new System.Drawing.Size(158, 24);
            this.txt_is.TabIndex = 3;
            // 
            // txt_pozisyon
            // 
            this.txt_pozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_pozisyon.Location = new System.Drawing.Point(56, 358);
            this.txt_pozisyon.Name = "txt_pozisyon";
            this.txt_pozisyon.Size = new System.Drawing.Size(158, 24);
            this.txt_pozisyon.TabIndex = 4;
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(51, 466);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(182, 41);
            this.pnl_ekle.TabIndex = 5;
            this.pnl_ekle.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Location = new System.Drawing.Point(304, 467);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(182, 41);
            this.pnl_geri.TabIndex = 6;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.pnl_ekle);
            this.Controls.Add(this.txt_pozisyon);
            this.Controls.Add(this.txt_is);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Name = "ekle";
            this.Text = "Müşteri İlişkileri Yönetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_is;
        private System.Windows.Forms.TextBox txt_pozisyon;
        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_geri;
    }
}