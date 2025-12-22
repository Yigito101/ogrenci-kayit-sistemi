using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace ÖğrenciKayıtSistemim
{
    public partial class OgrenciSilForm : Form
    {
        private const string DosyaYolu = "ogrenciler.txt";

        public OgrenciSilForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(OgrenciSilForm_Load);
        }

        private void OgrenciSilForm_Load(object? sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            try
            {
                listViewOgrenciler.Items.Clear();

                if (!File.Exists(DosyaYolu))
                {
                    return;
                }

                string[] satirlar = File.ReadAllLines(DosyaYolu);

                foreach (string satir in satirlar)
                {
                    string[] veriler = satir.Split(',');

                    if (veriler.Length == 5)
                    {
                        ListViewItem item = new ListViewItem(veriler[0]);
                        item.SubItems.Add(veriler[1]);
                        item.SubItems.Add(veriler[2]);
                        item.SubItems.Add(veriler[3]);
                        item.SubItems.Add(veriler[4]);

                        listViewOgrenciler.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenciler listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listViewOgrenciler.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult eminMisin = MessageBox.Show("Seçili öğrenciyi silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eminMisin == DialogResult.No)
            {
                return;
            }

            try
            {
                string seciliNumara = listViewOgrenciler.SelectedItems[0].SubItems[0].Text;
                List<string> tumSatirlar = File.ReadAllLines(DosyaYolu).ToList();

                string? silinecekSatir = tumSatirlar.FirstOrDefault(satir =>
                {
                    if (string.IsNullOrWhiteSpace(satir))
                        return false;

                    string[] veriler = satir.Split(',');

                    if (veriler.Length > 0 && veriler[0].Trim() == seciliNumara)
                        return true;

                    return false;
                });

                if (silinecekSatir != null)
                {
                    tumSatirlar.Remove(silinecekSatir);
                    File.WriteAllLines(DosyaYolu, tumSatirlar);
                    MessageBox.Show("Öğrenci başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListeyiDoldur();
                }
                else
                {
                    MessageBox.Show("Öğrenci dosyada bulunamadı (Numara: " + seciliNumara + ")", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}