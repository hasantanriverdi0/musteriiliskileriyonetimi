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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string musteri in veri.musteriListesi)
            {
                listBox1.Items.Add(musteri);
            }
        }

        private void pnl_ekle_Click(object sender, EventArgs e)
        {
            ekle ekleForm = new ekle();
            ekleForm.Show();
            this.Hide();
        }

        private void pnl_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Seçili öğeyi al
                string seciliMusteri = listBox1.SelectedItem.ToString();

                // Listeden kaldır
                veri.musteriListesi.Remove(seciliMusteri);

                // ListBox'tan da kaldır
                listBox1.Items.Remove(seciliMusteri);

                MessageBox.Show("Müşteri başarıyla silindi.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pnl_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_guncelle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                veri.seciliMusteri = listBox1.SelectedItem.ToString();
                guncelle guncelleForm = new guncelle();
                guncelleForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
