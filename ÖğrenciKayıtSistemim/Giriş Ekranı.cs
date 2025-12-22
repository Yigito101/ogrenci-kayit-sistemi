namespace ÖğrenciKayıtSistemim
{
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            string dkullaniciAdi = "admin";
            string dparola = "admin";

            string kullaniciAdi = kullaniciTxt.Text;
            string parola = parolaTxt.Text;

            if (kullaniciAdi == dkullaniciAdi && parola == dparola)
            {
                MessageBox.Show("Giris Basarili! Sisteme Yonlendiriliyorsunuz.");
                this.Hide();

                KayitSecenekleri kayitFormu = new KayitSecenekleri();
                kayitFormu.Show();

            }
            else
            {
                MessageBox.Show("Hatali Giris! Tekrar deneyin.");
                parolaTxt.Clear();

            }
        }
    }
}


        
