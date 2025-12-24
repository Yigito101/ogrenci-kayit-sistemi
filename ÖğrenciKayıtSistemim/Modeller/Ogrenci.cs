using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Modeller/Ogrenci.cs
namespace ÖğrenciKayıtSistemim.Modeller
{
    public class Ogrenci
    {
        public string Numara { get; set; } = string.Empty;
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Fakulte { get; set; } = "0";
        public string Bolum { get; set; } = string.Empty;

        // Veriyi dosyaya yazılacak formata çeviren yardımcı metot
        public string DosyaFormati()
        {
            return $"{Numara},{Ad},{Soyad},{Fakulte},{Bolum}";
        }
    }
}