using ÖğrenciKayıtSistemim.Modeller;
using ÖğrenciKayıtSistemim.Veri_Yönetimi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ÖğrenciKayıtSistemim.VeriYonetimi
{
    public class DosyaYoneticisi
    {
        private string _klasorYolu;

        private string OgrenciDosyaYolu => Path.Combine(_klasorYolu, "ogrenciler.txt");
        private string FakulteDosyaYolu => Path.Combine(_klasorYolu, "fakulteler.txt");
        private string BolumDosyaYolu => Path.Combine(_klasorYolu, "bolumler.txt");

        private LogYoneticisi _loglayici = new LogYoneticisi();

        public DosyaYoneticisi()
        {
            string anaDizin = AppDomain.CurrentDomain.BaseDirectory;
            _klasorYolu = Path.Combine(anaDizin, "VeriTabani");

            if (!Directory.Exists(_klasorYolu)) Directory.CreateDirectory(_klasorYolu);

            DosyaYoksaOlustur(OgrenciDosyaYolu);
            DosyaYoksaOlustur(FakulteDosyaYolu);
            DosyaYoksaOlustur(BolumDosyaYolu);
        }

        private void DosyaYoksaOlustur(string yol)
        {
            if (!File.Exists(yol)) File.Create(yol).Close();
        }

        private string SadeceRakamlariAl(string veri)
        {
            if (string.IsNullOrEmpty(veri)) return "";
            return new string(veri.Where(c => char.IsDigit(c)).ToArray());
        }

        public bool OgrenciVarMi(string numara)
        {
            if (!File.Exists(OgrenciDosyaYolu)) return false;
            string arananSaf = SadeceRakamlariAl(numara);
            foreach (string satir in File.ReadAllLines(OgrenciDosyaYolu))
            {
                if (string.IsNullOrWhiteSpace(satir)) continue;
                var parcalar = satir.Split(',');
                if (parcalar.Length > 0 && SadeceRakamlariAl(parcalar[0]) == arananSaf) return true;
            }
            return false;
        }

        // --- GÜNCELLENEN SİLME METODU ---
        public bool OgrenciSil(string silinecekNumara)
        {
            try
            {
                if (!File.Exists(OgrenciDosyaYolu))
                {
                    // "HATA" yerine LogTuru.HATA
                    _loglayici.LogEkle("Silme Başarısız: Dosya yok.", LogTuru.HATA);
                    return false;
                }

                string hedefNo = SadeceRakamlariAl(silinecekNumara);

                // "BİLGİ" yerine LogTuru.BILGI
                _loglayici.LogEkle($"Silme isteği: Aranan Saf='{hedefNo}'", LogTuru.BILGI);

                List<string> satirlar = File.ReadAllLines(OgrenciDosyaYolu).ToList();
                int silinecekIndex = -1;

                for (int i = 0; i < satirlar.Count; i++)
                {
                    string satir = satirlar[i];
                    if (string.IsNullOrWhiteSpace(satir)) continue;

                    var parcalar = satir.Split(',');
                    if (parcalar.Length > 0)
                    {
                        string dosyadakiNo = SadeceRakamlariAl(parcalar[0]);
                        if (dosyadakiNo == hedefNo)
                        {
                            silinecekIndex = i;
                            _loglayici.LogEkle($"EŞLEŞME: Satır {i}", LogTuru.BILGI); // Enum
                            break;
                        }
                    }
                }

                if (silinecekIndex != -1)
                {
                    satirlar.RemoveAt(silinecekIndex);
                    File.WriteAllLines(OgrenciDosyaYolu, satirlar);

                    // "BAŞARILI" yerine LogTuru.BASARILI
                    _loglayici.LogEkle($"[{hedefNo}] başarıyla silindi.", LogTuru.BASARILI);
                    return true;
                }
                else
                {
                    _loglayici.LogEkle($"Silinemedi. '{hedefNo}' bulunamadı.", LogTuru.UYARI); // Enum
                    return false;
                }
            }
            catch (Exception ex)
            {
                _loglayici.HataLogla(ex.Message, "OgrenciSil");
                return false;
            }
        }

        // --- GÜNCELLENEN EKLEME METODU ---
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            try
            {
                string satir = ogrenci.DosyaFormati().Trim();
                File.AppendAllText(OgrenciDosyaYolu, satir + Environment.NewLine);

                string mesaj = $"[{ogrenci.Numara}] sisteme eklendi.";
                // Enum kullanımı
                _loglayici.LogEkle(mesaj, LogTuru.BASARILI);
            }
            catch (Exception ex)
            {
                _loglayici.HataLogla(ex.Message, "OgrenciEkle");
                throw;
            }
        }

        // Fakülte var mı kontrolü
        public bool FakulteVarMi(string fakulteAdi)
        {
            if (!File.Exists(FakulteDosyaYolu)) return false;

            // Büyük/Küçük harf duyarsız kontrol (Mühendislik == mühendislik)
            var mevcutlar = File.ReadAllLines(FakulteDosyaYolu);
            return mevcutlar.Any(x => x.Trim().Equals(fakulteAdi.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        // Bölüm var mı kontrolü
        public bool BolumVarMi(string bolumAdi)
        {
            if (!File.Exists(BolumDosyaYolu)) return false;

            var mevcutlar = File.ReadAllLines(BolumDosyaYolu);
            return mevcutlar.Any(x => x.Trim().Equals(bolumAdi.Trim(), StringComparison.OrdinalIgnoreCase));
        }
        public void FakulteEkle(string fakulteAdi)
        {
            try
            {
                File.AppendAllText(FakulteDosyaYolu, fakulteAdi.Trim() + Environment.NewLine);
                // Enum kullanımı
                _loglayici.LogEkle($"Fakülte Eklendi: {fakulteAdi}", LogTuru.BASARILI);
            }
            catch (Exception ex) { _loglayici.HataLogla(ex.Message, "FakulteEkle"); throw; }
        }

        public void BolumEkle(string bolumAdi)
        {
            try
            {
                File.AppendAllText(BolumDosyaYolu, bolumAdi.Trim() + Environment.NewLine);
                // Enum kullanımı
                _loglayici.LogEkle($"Bölüm Eklendi: {bolumAdi}", LogTuru.BASARILI);
            }
            catch (Exception ex) { _loglayici.HataLogla(ex.Message, "BolumEkle"); throw; }
        }

        // Diğer metotlar aynı kalıyor...
        public List<Ogrenci> TumOgrencileriGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            if (File.Exists(OgrenciDosyaYolu))
            {
                foreach (string satir in File.ReadAllLines(OgrenciDosyaYolu))
                {
                    if (string.IsNullOrWhiteSpace(satir)) continue;
                    string[] parca = satir.Split(',');
                    if (parca.Length >= 5)
                    {
                        ogrenciler.Add(new Ogrenci { Numara = parca[0].Trim(), Ad = parca[1].Trim(), Soyad = parca[2].Trim(), Fakulte = parca[3].Trim(), Bolum = parca[4].Trim() });
                    }
                }
            }
            return ogrenciler;
        }

        public string[] ListeyiGetir(string listeTuru)
        {
            string dosyaYolu = listeTuru == "fakulte" ? FakulteDosyaYolu : BolumDosyaYolu;
            if (File.Exists(dosyaYolu)) return File.ReadAllLines(dosyaYolu);
            return new string[0];
        }
    }
}