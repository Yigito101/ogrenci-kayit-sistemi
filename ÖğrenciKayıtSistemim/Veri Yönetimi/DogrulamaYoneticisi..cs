using System.Text.RegularExpressions;

namespace ÖğrenciKayıtSistemim.VeriYonetimi
{
    public static class DogrulamaYoneticisi
    {
        // İsim sadece harflerden oluşmalı
        public static bool SadeceHarfMi(string metin)
        {
            if (string.IsNullOrWhiteSpace(metin)) return false;
            return Regex.IsMatch(metin, @"^[a-zA-ZçÇğĞıİöÖşŞüÜ ]+$");
        }

        // Numara sadece rakamlardan oluşmalı
        public static bool SadeceRakamMi(string metin)
        {
            if (string.IsNullOrWhiteSpace(metin)) return false;
            return Regex.IsMatch(metin, @"^[0-9]+$");
        }
    }
}