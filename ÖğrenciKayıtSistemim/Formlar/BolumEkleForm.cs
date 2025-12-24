using System;
using System.Windows.Forms;
using ÖğrenciKayıtSistemim.Veri_Yönetimi; // <--- BU SATIRI MUTLAKA EKLE (LogTuru için)
using ÖğrenciKayıtSistemim.VeriYonetimi;

namespace ÖğrenciKayıtSistemim.Formlar
{
    public partial class BolumEkleForm : Form
    {
        private DosyaYoneticisi _yonetici = new DosyaYoneticisi();
        private LogYoneticisi _loglayici = new LogYoneticisi();

        public BolumEkleForm()
        {
            InitializeComponent();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            // 1. Boşluk Kontrolü
            if (string.IsNullOrWhiteSpace(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // ESKİSİ: "UYARI"
                // YENİSİ: LogTuru.UYARI
                _loglayici.LogEkle("Bölüm ekleme başarısız: Alan boş bırakıldı.", LogTuru.UYARI);
                return;
            }

            // 2. Mantıksal Kontrol
            if (!DogrulamaYoneticisi.SadeceHarfMi(txtBolumAdi.Text))
            {
                MessageBox.Show("Bölüm adı sadece harflerden oluşmalıdır!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // DÜZELTME
                _loglayici.LogEkle($"Bölüm ekleme başarısız: Geçersiz karakter girildi ({txtBolumAdi.Text}).", LogTuru.UYARI);

                txtBolumAdi.Clear();
                txtBolumAdi.Focus();
                return;
            }

            if (_yonetici.BolumVarMi(txtBolumAdi.Text))
            {
                MessageBox.Show("Bu bölüm zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _loglayici.LogEkle($"Bölüm Ekleme Başarısız: {txtBolumAdi.Text} zaten var.", LogTuru.UYARI);
                return;
            }

            try
            {
                _yonetici.BolumEkle(txtBolumAdi.Text.Trim());
                MessageBox.Show("Bölüm başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBolumAdi.Clear();
                txtBolumAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void BolumEkleForm_Load(object sender, EventArgs e)
        {

        }
    }
}