using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ÖğrenciKayıtSistemim.Modeller;
using ÖğrenciKayıtSistemim.VeriYonetimi;
using ÖğrenciKayıtSistemim.Veri_Yönetimi; // <--- LogTuru için bu satır eklendi

namespace ÖğrenciKayıtSistemim.Formlar
{
    public partial class OgrenciSilForm : Form
    {
        private DosyaYoneticisi _yonetici = new DosyaYoneticisi();
        private LogYoneticisi _loglayici = new LogYoneticisi();
        private ListViewColumnSorter _siraliyici;

        public OgrenciSilForm()
        {
            InitializeComponent();

            this.Activated += OgrenciSilForm_Activated;

            // --- LISTVIEW AYARLARI ---
            listViewOgrenciler.CheckBoxes = true;
            listViewOgrenciler.GridLines = true;
            listViewOgrenciler.FullRowSelect = true;
            listViewOgrenciler.View = View.Details;
            listViewOgrenciler.MultiSelect = false;

            // Olaylar
            listViewOgrenciler.DoubleClick += ListViewOgrenciler_DoubleClick;

            // Sıralama
            _siraliyici = new ListViewColumnSorter();
            listViewOgrenciler.ListViewItemSorter = _siraliyici;
            listViewOgrenciler.ColumnClick += ListViewOgrenciler_ColumnClick;
        }

        private void OgrenciSilForm_Activated(object? sender, EventArgs e)
        {
            ListeyiYenile();
        }

        // Çift Tıklama: Tik durumunu tersine çevirir
        private void ListViewOgrenciler_DoubleClick(object? sender, EventArgs e)
        {
            if (listViewOgrenciler.SelectedItems.Count > 0)
            {
                var item = listViewOgrenciler.SelectedItems[0];
                item.Checked = !item.Checked;
            }
        }

        // Listeyi Doldurma
        private void ListeyiYenile()
        {
            listViewOgrenciler.BeginUpdate();
            listViewOgrenciler.Items.Clear();

            // Başlıkları ayarla
            if (listViewOgrenciler.Columns.Count > 0) listViewOgrenciler.Columns[0].Text = "Seçim / No";

            try
            {
                List<Ogrenci> ogrenciler = _yonetici.TumOgrencileriGetir();

                foreach (var ogr in ogrenciler)
                {
                    // Numarayı temizleyerek ekle
                    ListViewItem item = new ListViewItem(ogr.Numara.Trim());
                    item.SubItems.Add(ogr.Ad);
                    item.SubItems.Add(ogr.Soyad);
                    item.SubItems.Add(ogr.Fakulte);
                    item.SubItems.Add(ogr.Bolum);

                    item.Checked = false; // Varsayılan boş gelsin

                    listViewOgrenciler.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
            finally
            {
                listViewOgrenciler.EndUpdate();
            }
        }

        // --- GÜNCELLENMİŞ SİLME BUTONU ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silinecekleri toplayacağımız liste
            List<ListViewItem> silinecekler = new List<ListViewItem>();

            // 1. Önce TİKLİ (Checkbox) olanları listeye at
            foreach (ListViewItem item in listViewOgrenciler.CheckedItems)
            {
                silinecekler.Add(item);
            }

            // 2. Eğer hiç tikli yoksa ama kullanıcı satırı MAVİ seçmişse onu da ekle
            if (silinecekler.Count == 0 && listViewOgrenciler.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewOgrenciler.SelectedItems)
                {
                    silinecekler.Add(item);
                }
            }

            // --- KONTROL: Hala silinecek bir şey yoksa uyar ---
            if (silinecekler.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek öğrenciyi seçin (Kutucuğu işaretleyin veya isme tıklayın).", "Seçim Yok", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // GÜNCELLEME: LogTuru enum'ı kullanıldı
                _loglayici.LogEkle("Silme denemesi başarısız: Seçim yapılmadı (Ne tikli ne de seçili öğe var).", LogTuru.UYARI);

                return;
            }

            // Onay İste
            DialogResult cevap = MessageBox.Show(
                $"{silinecekler.Count} adet öğrenciyi silmek istiyor musunuz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                int basariliSilinen = 0;

                try
                {
                    foreach (ListViewItem item in silinecekler)
                    {
                        string numara = item.Text.Trim();

                        // Dosya Yöneticisine Gönder
                        bool sonuc = _yonetici.OgrenciSil(numara);
                        if (sonuc)
                        {
                            basariliSilinen++;
                        }
                    }

                    if (basariliSilinen > 0)
                    {
                        MessageBox.Show($"{basariliSilinen} öğrenci başarıyla silindi.", "Başarılı");
                        ListeyiYenile(); // Listeyi güncelle
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleşmedi. (Log dosyasına bakınız)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında hata: " + ex.Message);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeyiYenile();
        }

        // --- SIRALAMA MANTIĞI ---
        private void ListViewOgrenciler_ColumnClick(object? sender, ColumnClickEventArgs e)
        {
            if (e.Column == _siraliyici.SortColumn)
            {
                if (_siraliyici.Order == SortOrder.Ascending)
                    _siraliyici.Order = SortOrder.Descending;
                else
                    _siraliyici.Order = SortOrder.Ascending;
            }
            else
            {
                _siraliyici.SortColumn = e.Column;
                _siraliyici.Order = SortOrder.Ascending;
            }
            listViewOgrenciler.Sort();
        }
    }

    // --- SIRALAYICI SINIF (AYNI) ---
    public class ListViewColumnSorter : IComparer
    {
        public int SortColumn { get; set; } = 0;
        public SortOrder Order { get; set; } = SortOrder.Ascending;
        private CaseInsensitiveComparer ObjectCompare = new CaseInsensitiveComparer();

        public int Compare(object? x, object? y)
        {
            ListViewItem listviewX = (ListViewItem)x!;
            ListViewItem listviewY = (ListViewItem)y!;

            int compareResult;

            if (SortColumn == 0)
            {
                long numX, numY;
                bool xIsNum = long.TryParse(listviewX.SubItems[SortColumn].Text, out numX);
                bool yIsNum = long.TryParse(listviewY.SubItems[SortColumn].Text, out numY);

                if (xIsNum && yIsNum) compareResult = numX.CompareTo(numY);
                else compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
            }
            else
            {
                compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);
            }

            if (Order == SortOrder.Ascending) return compareResult;
            else if (Order == SortOrder.Descending) return (-1) * compareResult;
            else return 0;
        }
    }
}