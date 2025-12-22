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
    public partial class OgrenciEkleForm : Form
    {
        public OgrenciEkleForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(OgrenciEkleForm_Load);
        }

        private void OgrenciEkleForm_Load(object? sender, EventArgs e)
        {
            try
            {
                if (File.Exists("fakulteler.txt"))
                {
                    string[] fakulteler = File.ReadAllLines("fakulteler.txt");
                    cmbFakulte.Items.AddRange(fakulteler);
                }

                if (File.Exists("bolumler.txt"))
                {
                    string[] bolumler = File.ReadAllLines("bolumler.txt");
                    cmbBolum.Items.AddRange(bolumler);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeler yüklenirken hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnÖğrenciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = Adtxt.Text;
                string soyad = Soyadtxt.Text;
                string numara = NumaraTxt.Text;
                string fakulte = cmbFakulte.Text;
                string bolum = cmbBolum.Text;

                if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(numara) || string.IsNullOrWhiteSpace(fakulte) || string.IsNullOrWhiteSpace(bolum))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string kaydedilecekSatir = $"{numara},{ad},{soyad},{fakulte},{bolum}";
                File.AppendAllText("ogrenciler.txt", kaydedilecekSatir + Environment.NewLine);

                MessageBox.Show("Öğrenci başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Adtxt.Clear();
                Soyadtxt.Clear();
                NumaraTxt.Clear();
                Adtxt.Focus();
                cmbFakulte.Text = "";
                cmbBolum.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}