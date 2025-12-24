using System;
using System.Windows.Forms;
using ÖğrenciKayıtSistemim.Veri_Yönetimi; // <--- EKLENDİ
using ÖğrenciKayıtSistemim.VeriYonetimi;

namespace ÖğrenciKayıtSistemim.Formlar
{
    public partial class FakulteEkleForm : Form
    {
        private DosyaYoneticisi _yonetici = new DosyaYoneticisi();
        private LogYoneticisi _loglayici = new LogYoneticisi();

        public FakulteEkleForm()
        {
            InitializeComponent();
        }

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFakulteAdi.Text))
            {
                MessageBox.Show("Fakülte adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // DÜZELTME: LogTuru.UYARI
                _loglayici.LogEkle("Fakülte ekleme başarısız: Alan boş bırakıldı.", LogTuru.UYARI);
                return;
            }

            if (!DogrulamaYoneticisi.SadeceHarfMi(txtFakulteAdi.Text))
            {
                MessageBox.Show("Fakülte adı sadece harflerden oluşmalıdır!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // DÜZELTME
                _loglayici.LogEkle($"Fakülte ekleme başarısız: Geçersiz karakter girildi ({txtFakulteAdi.Text}).", LogTuru.UYARI);

                txtFakulteAdi.Clear();
                txtFakulteAdi.Focus();
                return;
            }

            if (_yonetici.FakulteVarMi(txtFakulteAdi.Text))
            {
                MessageBox.Show("Bu fakülte zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _loglayici.LogEkle($"Fakülte Ekleme Başarısız: {txtFakulteAdi.Text} zaten var.", LogTuru.UYARI);
                return;
            }

            try
            {
                _yonetici.FakulteEkle(txtFakulteAdi.Text.Trim());
                MessageBox.Show("Fakülte başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFakulteAdi.Clear();
                txtFakulteAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void FakulteEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}