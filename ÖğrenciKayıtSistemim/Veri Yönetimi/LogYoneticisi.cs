using ÖğrenciKayıtSistemim.Veri_Yönetimi;
using System;
using System.IO;
using System.Windows.Forms;

namespace ÖğrenciKayıtSistemim.VeriYonetimi
{
    public class LogYoneticisi
    {
        private string _logDosyaYolu;

        public LogYoneticisi()
        {
            string projeDizini = AppDomain.CurrentDomain.BaseDirectory;
            _logDosyaYolu = Path.Combine(projeDizini, "sistem_loglari.txt");
        }

        // DEĞİŞİKLİK BURADA: 'string tur' yerine 'LogTuru tur'
        public void LogEkle(string mesaj, LogTuru tur)
        {
            try
            {
                // Enum'ı string'e çevirerek yazıyoruz (tur.ToString())
                string logSatiri = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss} - [{tur}] -> {mesaj}";
                File.AppendAllText(_logDosyaYolu, logSatiri + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Log yazılamadı!\nHata: {ex.Message}");
            }
        }

        public void HataLogla(string hataMesaji, string yer)
        {
            // İçerideki çağrıyı da Enum'a çevirdik
            LogEkle($"Sistemsel Hata ({yer}): {hataMesaji}", LogTuru.HATA);
        }
    }
}