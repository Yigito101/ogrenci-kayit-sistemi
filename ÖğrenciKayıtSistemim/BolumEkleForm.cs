using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciKayıtSistemim
{
    public partial class BolumEkleForm : Form
    {
        public BolumEkleForm()
        {
            InitializeComponent();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string bolumAdi = txtBolumAdi.Text;
                if (string.IsNullOrWhiteSpace(bolumAdi))
                {
                    MessageBox.Show("Lütfen bölüm adını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                File.AppendAllText("bolumler.txt", bolumAdi + Environment.NewLine);
                MessageBox.Show("Bölüm başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBolumAdi.Clear();
                txtBolumAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölüm eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
