using System;
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
    public partial class KayitSecenekleri : Form
    {
        public KayitSecenekleri()
        {
            InitializeComponent();

            this.FormClosed += new FormClosedEventHandler(KayitSecenekleri_FormClosed);
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm ogrencieklle = new OgrenciEkleForm();
            ogrencieklle.Show();
        }

        private void btnOgrenciSi_Click(object sender, EventArgs e)
        {
            OgrenciSilForm ogrenciSil = new OgrenciSilForm();
            ogrenciSil.Show();
        }

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            FakulteEkleForm fakulteEkle = new FakulteEkleForm();
            fakulteEkle.Show();
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkleForm bolumEkle = new BolumEkleForm();
            bolumEkle.Show();
        }
        private void KayitSecenekleri_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
