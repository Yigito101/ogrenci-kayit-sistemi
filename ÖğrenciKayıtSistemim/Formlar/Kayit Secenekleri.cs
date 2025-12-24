using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ÖğrenciKayıtSistemim.Formlar
{
    public partial class KayitSecenekleri : Form
    {
        public KayitSecenekleri()
        {
            InitializeComponent();
            // Form kapatıldığında tüm uygulamayı durduracak olayı bağlıyoruz
            this.FormClosed += new FormClosedEventHandler(KayitSecenekleri_FormClosed);
        }

        // --- ÖĞRENCİ EKLEME ---
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm ogrenciEkle = new OgrenciEkleForm();
            ogrenciEkle.StartPosition = FormStartPosition.CenterParent; // Ana formun ortasında aç
            ogrenciEkle.ShowDialog(); // Ana formu kilitle (Arkaya tıklanamaz)
        }

        // --- ÖĞRENCİ SİLME ---
        private void btnOgrenciSi_Click(object sender, EventArgs e)
        {
            OgrenciSilForm ogrenciSil = new OgrenciSilForm();
            ogrenciSil.StartPosition = FormStartPosition.CenterParent;
            ogrenciSil.ShowDialog();
        }

        // --- FAKÜLTE EKLEME ---
        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            FakulteEkleForm fakulteEkle = new FakulteEkleForm();
            fakulteEkle.StartPosition = FormStartPosition.CenterParent;
            fakulteEkle.ShowDialog();
        }

        // --- BÖLÜM EKLEME ---
        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkleForm bolumEkle = new BolumEkleForm();
            bolumEkle.StartPosition = FormStartPosition.CenterParent;
            bolumEkle.ShowDialog();
        }


        // Bu metodu sınıfın içine ekle
        private void btnDosyalariAc_Click(object sender, EventArgs e)
        {
            try
            {
                // Programın çalıştığı ve dosyaların olduğu gerçek yolu buluyoruz
                string dosyaYolu = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "VeriTabani");

                // Eğer klasör varsa aç
                if (System.IO.Directory.Exists(dosyaYolu))
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = dosyaYolu,
                        UseShellExecute = true,
                        Verb = "open"
                    });
                }
                else
                {
                    MessageBox.Show("Henüz hiç kayıt yapılmadığı için klasör oluşmamış.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klasör açılırken hata oluştu: " + ex.Message);
            }
        }

        // --- ÇIKIŞ İŞLEMİ ---
        // 'object? sender' diyerek null uyarısını (CS8622) engelliyoruz.
        private void KayitSecenekleri_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Uygulamayı RAM'den tamamen siler
        }

        private void KayitSecenekleri_Load(object sender, EventArgs e)
        {

        }
    }
}