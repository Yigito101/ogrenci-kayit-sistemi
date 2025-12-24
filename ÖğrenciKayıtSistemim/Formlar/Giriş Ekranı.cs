using System;
using System.Windows.Forms;

namespace ÖðrenciKayýtSistemim.Formlar
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        // HATA GÝDERÝCÝ 1: Designer'da tanýmlý olan Load olayý için boþ bir metot
        private void girisForm_Load(object sender, EventArgs e)
        {
            // Burasý form yüklenirken çalýþýr, þu an boþ kalabilir.
        }

        // HATA GÝDERÝCÝ 2: Designer'da kalan label2_Click olayý için boþ bir metot
        private void label2_Click(object sender, EventArgs e)
        {
            // Eðer "Þifremi Unuttum" gibi bir özellik yoksa boþ kalabilir.
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            // Admin bilgileri (Ýstersen DosyaYoneticisi'nden de çekebiliriz)
            string dogruKullanici = "admin";
            string dogruParola = "admin";

            if (kullaniciTxt.Text == dogruKullanici && parolaTxt.Text == dogruParola)
            {
                // Giriþ Baþarýlý
                // HATA GÝDERÝCÝ 3: 'AnaMenuForm' yerine 'KayitSecenekleri' formunu açýyoruz
                KayitSecenekleri anaMenu = new KayitSecenekleri();
                anaMenu.Show();
                this.Hide();
            }
            else
            {
                // Giriþ Baþarýsýz
                MessageBox.Show("Kullanýcý adý veya parola hatalý!", "Giriþ Baþarýsýz", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // --- ÝSTEDÝÐÝN DÜZELTME ---
                // Hem parolayý hem kullanýcý adýný temizle
                parolaTxt.Clear();
                kullaniciTxt.Clear();

                // Ýmleci tekrar kullanýcý adýna odakla (Kullanýcý dostu hareket)
                kullaniciTxt.Focus();
            }
        }

        private void girisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}