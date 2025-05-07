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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chc_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !chc.Checked;
        }
        private void giris_Load(object sender, EventArgs e)
        {
            chc.Checked = false; // checkbox işaretli gelmesin
            textBox2.UseSystemPasswordChar = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string kullaniciAd = textBox1.Text.Trim();
            string sifre = textBox2.Text.Trim();

            // Örnek admin kontrolü
            if (kullaniciAd == "admin" && sifre == "1234")
            {
                anasayfa ana = new anasayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chc.Checked = false; // checkbox işaretli gelmesin
            textBox2.UseSystemPasswordChar = true;
        }
    }
}
