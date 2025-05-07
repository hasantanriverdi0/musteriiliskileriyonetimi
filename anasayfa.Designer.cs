namespace musteriiliskileriyonetimi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnl_ekle = new System.Windows.Forms.Panel();
            this.pnl_sil = new System.Windows.Forms.Panel();
            this.pnl_cikis = new System.Windows.Forms.Panel();
            this.pnl_guncelle = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 600;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(51, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 316);
            this.listBox1.TabIndex = 0;
            // 
            // pnl_ekle
            // 
            this.pnl_ekle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_ekle.Location = new System.Drawing.Point(51, 468);
            this.pnl_ekle.Name = "pnl_ekle";
            this.pnl_ekle.Size = new System.Drawing.Size(101, 37);
            this.pnl_ekle.TabIndex = 1;
            this.pnl_ekle.Click += new System.EventHandler(this.pnl_ekle_Click);
            // 
            // pnl_sil
            // 
            this.pnl_sil.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sil.Location = new System.Drawing.Point(163, 467);
            this.pnl_sil.Name = "pnl_sil";
            this.pnl_sil.Size = new System.Drawing.Size(101, 37);
            this.pnl_sil.TabIndex = 2;
            this.pnl_sil.Click += new System.EventHandler(this.pnl_sil_Click);
            // 
            // pnl_cikis
            // 
            this.pnl_cikis.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cikis.Location = new System.Drawing.Point(388, 468);
            this.pnl_cikis.Name = "pnl_cikis";
            this.pnl_cikis.Size = new System.Drawing.Size(101, 37);
            this.pnl_cikis.TabIndex = 4;
            this.pnl_cikis.Click += new System.EventHandler(this.pnl_cikis_Click);
            // 
            // pnl_guncelle
            // 
            this.pnl_guncelle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_guncelle.Location = new System.Drawing.Point(277, 469);
            this.pnl_guncelle.Name = "pnl_guncelle";
            this.pnl_guncelle.Size = new System.Drawing.Size(101, 37);
            this.pnl_guncelle.TabIndex = 3;
            this.pnl_guncelle.Click += new System.EventHandler(this.pnl_guncelle_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_cikis);
            this.Controls.Add(this.pnl_sil);
            this.Controls.Add(this.pnl_guncelle);
            this.Controls.Add(this.pnl_ekle);
            this.Controls.Add(this.listBox1);
            this.Name = "anasayfa";
            this.Text = "Müşteri İlişkileri Yönetimi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnl_ekle;
        private System.Windows.Forms.Panel pnl_sil;
        private System.Windows.Forms.Panel pnl_cikis;
        private System.Windows.Forms.Panel pnl_guncelle;
    }
}