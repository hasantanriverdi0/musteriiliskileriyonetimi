using System;
using System.Windows.Forms;

namespace musteriiliskileriyonetimi
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void pnl_guncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string ad = txt_ad.Text.Trim();
            string soyad = txt_soyad.Text.Trim();
            string isyeri = txt_is.Text.Trim();
            string pozisyon = txt_pozisyon.Text.Trim();

            if (ad == "" || soyad == "" || isyeri == "" || pozisyon == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yeniMusteri = $"Ad: {ad}, Soyad: {soyad}, İş Yeri: {isyeri}, Pozisyonu: {pozisyon}";
            veri.musteriListesi.Add(yeniMusteri); // Kalıcı listeye ekle

            MessageBox.Show("Müşteri başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Anasayfaya geri dön
            anasayfa ana = new anasayfa();
            ana.Show();
            this.Hide();
        }
    }
}
