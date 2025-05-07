using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musteriiliskileriyonetimi
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            string[] bilgiler = veri.seciliMusteri.Split(',');

            if (bilgiler.Length == 4)
            {
                txt_ad.Text = bilgiler[0].Replace("Ad:", "").Trim();
                txt_soyad.Text = bilgiler[1].Replace("Soyad:", "").Trim();
                txt_is.Text = bilgiler[2].Replace("İş Yeri:", "").Trim();
                txt_pozisyon.Text = bilgiler[3].Replace("Pozisyonu:", "").Trim();
            }
        }

        private void pnl_guncelle_Click(object sender, EventArgs e)
        {
            string yeniAd = txt_ad.Text.Trim();
            string yeniSoyad = txt_soyad.Text.Trim();
            string yeniIs = txt_is.Text.Trim();
            string yeniPozisyon = txt_pozisyon.Text.Trim();

            if (yeniAd == "" || yeniSoyad == "" || yeniIs == "" || yeniPozisyon == "")
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yeniMusteri = $"Ad: {yeniAd}, Soyad: {yeniSoyad}, İş Yeri: {yeniIs}, Pozisyonu: {yeniPozisyon}";

            int index = veri.musteriListesi.IndexOf(veri.seciliMusteri);
            if (index != -1)
            {
                veri.musteriListesi[index] = yeniMusteri;
            }

            MessageBox.Show("Müşteri bilgileri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Geri dön
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void pnl_cikis_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
