using System;
using System.Windows.Forms;
using ÖğrenciKayıtSistemim.Modeller;      // Model sınıfı
using ÖğrenciKayıtSistemim.VeriYonetimi;  // Dosya ve Log yöneticileri
using ÖğrenciKayıtSistemim.Veri_Yönetimi; // LogTuru Enum'ı için gerekli (MUTLAKA EKLE)

namespace ÖğrenciKayıtSistemim.Formlar
{
    public partial class OgrenciEkleForm : Form
    {
        // Dosya ve Log yöneticilerini tanımlıyoruz
        private DosyaYoneticisi _yonetici = new DosyaYoneticisi();
        private LogYoneticisi _loglayici = new LogYoneticisi();

        public OgrenciEkleForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(OgrenciEkleForm_Load);
        }

        private void OgrenciEkleForm_Load(object? sender, EventArgs e)
        {
            try
            {
                cmbFakulte.Items.AddRange(_yonetici.ListeyiGetir("fakulte"));
                cmbBolum.Items.AddRange(_yonetici.ListeyiGetir("bolum"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeler yüklenirken hata: " + ex.Message);
                _loglayici.HataLogla(ex.Message, "OgrenciEkleForm_Load");
            }
        }

        private void BtnÖğrenciEkle_Click(object sender, EventArgs e)
        {
            // 1. Temel Boşluk Kontrolü ve UYARI LOGLAMA
            if (string.IsNullOrWhiteSpace(Adtxt.Text) ||
                string.IsNullOrWhiteSpace(Soyadtxt.Text) ||
                string.IsNullOrWhiteSpace(NumaraTxt.Text) ||
                string.IsNullOrWhiteSpace(cmbFakulte.Text) ||
                string.IsNullOrWhiteSpace(cmbBolum.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // LOG: Enum kullanarak uyarı logu
                _loglayici.LogEkle("Öğrenci ekleme başarısız: Zorunlu alanlar boş bırakıldı.", LogTuru.UYARI);

                FormuTemizle();
                return;
            }

            // 2. Mantıksal Hata Kontrolleri

            // Ad Kontrolü
            if (!DogrulamaYoneticisi.SadeceHarfMi(Adtxt.Text))
            {
                MessageBox.Show("Ad alanı sadece harflerden oluşmalıdır! (Örn: Ahmet)", "Geçersiz Ad", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _loglayici.LogEkle($"Öğrenci ekleme başarısız: Ad alanına geçersiz veri girildi ({Adtxt.Text}).", LogTuru.UYARI);

                Adtxt.Clear();
                Adtxt.Focus();
                return;
            }

            // Soyad Kontrolü
            if (!DogrulamaYoneticisi.SadeceHarfMi(Soyadtxt.Text))
            {
                MessageBox.Show("Soyad alanı sadece harflerden oluşmalıdır!", "Geçersiz Soyad", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _loglayici.LogEkle($"Öğrenci ekleme başarısız: Soyad alanına geçersiz veri girildi ({Soyadtxt.Text}).", LogTuru.UYARI);

                Soyadtxt.Clear();
                Soyadtxt.Focus();
                return;
            }

            // Numara Kontrolü
            if (!DogrulamaYoneticisi.SadeceRakamMi(NumaraTxt.Text))
            {
                MessageBox.Show("Öğrenci numarası sadece rakamlardan oluşmalıdır!", "Geçersiz Numara", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                _loglayici.LogEkle($"Öğrenci ekleme başarısız: Numara alanına harf girildi ({NumaraTxt.Text}).", LogTuru.UYARI);

                NumaraTxt.Clear();
                NumaraTxt.Focus();
                return;
            }

            // --- MÜKERRER KAYIT KONTROLÜ (Aynı numara var mı?) ---
            if (_yonetici.OgrenciVarMi(NumaraTxt.Text))
            {
                MessageBox.Show($"Bu numara ({NumaraTxt.Text}) ile kayıtlı bir öğrenci zaten var!\nLütfen farklı bir numara giriniz.", "Mükerrer Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _loglayici.LogEkle($"Ekleme Başarısız: {NumaraTxt.Text} numarası zaten sistemde mevcut.", LogTuru.UYARI);

                NumaraTxt.Clear();
                NumaraTxt.Focus();
                return;
            }

            // 3. Kayıt İşlemi
            try
            {
                Ogrenci yeniOgrenci = new Ogrenci
                {
                    Ad = Adtxt.Text.Trim(),
                    Soyad = Soyadtxt.Text.Trim(),
                    Numara = NumaraTxt.Text.Trim(),
                    Fakulte = cmbFakulte.Text,
                    Bolum = cmbBolum.Text
                };

                // Yönetici eklerken loglamayı (BAŞARILI) kendi içinde yapıyor
                _yonetici.OgrenciEkle(yeniOgrenci);

                MessageBox.Show("Öğrenci başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Sadece Harf Girilmesine İzin Veren Olay
        private void SadeceHarf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        // Sadece Rakam Girilmesine İzin Veren Olay
        private void SadeceRakam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Tuşu engelle
            }
        }

        private void FormuTemizle()
        {
            Adtxt.Clear();
            Soyadtxt.Clear();
            NumaraTxt.Clear();
            Adtxt.Focus();
            cmbFakulte.SelectedIndex = -1;
            cmbBolum.SelectedIndex = -1;
        }
    }
}