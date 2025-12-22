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
    public partial class FakulteEkleForm : Form
    {
        public FakulteEkleForm()
        {
            InitializeComponent();
        }

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string fakulteAdi = txtFakulteAdi.Text;
                if (string.IsNullOrWhiteSpace(fakulteAdi))
                {
                    MessageBox.Show("Lütfen fakülte adını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                File.AppendAllText("fakulteler.txt", fakulteAdi + Environment.NewLine);
                MessageBox.Show("Fakülte başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFakulteAdi.Clear();
                txtFakulteAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fakülte eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
