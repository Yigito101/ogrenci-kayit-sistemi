namespace ÖğrenciKayıtSistemim.Formlar
{
    partial class KayitSecenekleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelKontrol = new Label();
            btnOgrenciEkle = new Button();
            btnOgrenciSi = new Button();
            btnFakulteEkle = new Button();
            btnBolumEkle = new Button();
            btnDosyalariAc = new Button(); // YENİ BUTON TANIMI
            SuspendLayout();
            // 
            // labelKontrol
            // 
            labelKontrol.AutoSize = true;
            labelKontrol.Font = new Font("Impact", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 162);
            labelKontrol.Location = new Point(202, 50);
            labelKontrol.Name = "labelKontrol";
            labelKontrol.Size = new Size(175, 35);
            labelKontrol.TabIndex = 0;
            labelKontrol.Text = "Kontrol Paneli";
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOgrenciEkle.Location = new Point(202, 135);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(175, 48);
            btnOgrenciEkle.TabIndex = 1;
            btnOgrenciEkle.Text = "Öğrenci Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // btnOgrenciSi
            // 
            btnOgrenciSi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnOgrenciSi.Location = new Point(202, 217);
            btnOgrenciSi.Name = "btnOgrenciSi";
            btnOgrenciSi.Size = new Size(175, 48);
            btnOgrenciSi.TabIndex = 2;
            btnOgrenciSi.Text = "Öğrenci Sil";
            btnOgrenciSi.UseVisualStyleBackColor = true;
            btnOgrenciSi.Click += btnOgrenciSi_Click;
            // 
            // btnFakulteEkle
            // 
            btnFakulteEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFakulteEkle.Location = new Point(202, 299);
            btnFakulteEkle.Name = "btnFakulteEkle";
            btnFakulteEkle.Size = new Size(175, 48);
            btnFakulteEkle.TabIndex = 3;
            btnFakulteEkle.Text = "Fakülte Ekle";
            btnFakulteEkle.UseVisualStyleBackColor = true;
            btnFakulteEkle.Click += btnFakulteEkle_Click;
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBolumEkle.Location = new Point(202, 381);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(175, 48);
            btnBolumEkle.TabIndex = 4;
            btnBolumEkle.Text = "Bölüm Ekle";
            btnBolumEkle.UseVisualStyleBackColor = true;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // btnDosyalariAc (YENİ BUTON AYARLARI)
            // 
            btnDosyalariAc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDosyalariAc.ForeColor = Color.DarkBlue; // Dikkat çekmesi için rengi farklı olsun
            btnDosyalariAc.Location = new Point(202, 463); // Diğerlerinin altına hizalandı
            btnDosyalariAc.Name = "btnDosyalariAc";
            btnDosyalariAc.Size = new Size(175, 48);
            btnDosyalariAc.TabIndex = 5;
            btnDosyalariAc.Text = "Veri Klasörünü Aç";
            btnDosyalariAc.UseVisualStyleBackColor = true;
            btnDosyalariAc.Click += btnDosyalariAc_Click;
            // 
            // KayitSecenekleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            // Formun boyunu uzattık ki yeni buton sığsın (550 yaptık)
            ClientSize = new Size(593, 550);
            Controls.Add(btnDosyalariAc); // YENİ BUTONU FORMA EKLE
            Controls.Add(btnBolumEkle);
            Controls.Add(btnFakulteEkle);
            Controls.Add(btnOgrenciSi);
            Controls.Add(btnOgrenciEkle);
            Controls.Add(labelKontrol);
            Name = "KayitSecenekleri";
            Text = "KayitSecenekleri";
            Load += KayitSecenekleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKontrol;
        private Button btnOgrenciEkle;
        private Button btnOgrenciSi;
        private Button btnFakulteEkle;
        private Button btnBolumEkle;
        private Button btnDosyalariAc; // YENİ BUTON DEĞİŞKENİ
    }
}