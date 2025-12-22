namespace ÖğrenciKayıtSistemim
{
    partial class OgrenciEkleForm
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
            lblEkleSoyad = new Label();
            lblEkleAd = new Label();
            Adtxt = new TextBox();
            Soyadtxt = new TextBox();
            BtnÖğrenciEkle = new Button();
            lblÖğrenciEkle = new Label();
            NumaraTxt = new TextBox();
            lblEkleNumara = new Label();
            lblFakulteSec = new Label();
            lblBolumSec = new Label();
            cmbBolum = new ComboBox();
            cmbFakulte = new ComboBox();
            SuspendLayout();
            // 
            // lblEkleSoyad
            // 
            lblEkleSoyad.AutoSize = true;
            lblEkleSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEkleSoyad.Location = new Point(83, 165);
            lblEkleSoyad.Name = "lblEkleSoyad";
            lblEkleSoyad.Size = new Size(55, 20);
            lblEkleSoyad.TabIndex = 0;
            lblEkleSoyad.Text = "Soyad:";
            // 
            // lblEkleAd
            // 
            lblEkleAd.AutoSize = true;
            lblEkleAd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEkleAd.Location = new Point(105, 101);
            lblEkleAd.Name = "lblEkleAd";
            lblEkleAd.Size = new Size(33, 20);
            lblEkleAd.TabIndex = 1;
            lblEkleAd.Text = "Ad:";
            // 
            // Adtxt
            // 
            Adtxt.Location = new Point(149, 98);
            Adtxt.Name = "Adtxt";
            Adtxt.Size = new Size(185, 27);
            Adtxt.TabIndex = 1;
            // 
            // Soyadtxt
            // 
            Soyadtxt.Location = new Point(149, 162);
            Soyadtxt.Name = "Soyadtxt";
            Soyadtxt.Size = new Size(185, 27);
            Soyadtxt.TabIndex = 2;
            // 
            // BtnÖğrenciEkle
            // 
            BtnÖğrenciEkle.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnÖğrenciEkle.Location = new Point(194, 420);
            BtnÖğrenciEkle.Name = "BtnÖğrenciEkle";
            BtnÖğrenciEkle.Size = new Size(94, 56);
            BtnÖğrenciEkle.TabIndex = 4;
            BtnÖğrenciEkle.Text = "Ekle";
            BtnÖğrenciEkle.UseVisualStyleBackColor = true;
            BtnÖğrenciEkle.Click += BtnÖğrenciEkle_Click;
            // 
            // lblÖğrenciEkle
            // 
            lblÖğrenciEkle.AutoSize = true;
            lblÖğrenciEkle.BorderStyle = BorderStyle.FixedSingle;
            lblÖğrenciEkle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblÖğrenciEkle.Location = new Point(173, 31);
            lblÖğrenciEkle.Name = "lblÖğrenciEkle";
            lblÖğrenciEkle.Size = new Size(137, 30);
            lblÖğrenciEkle.TabIndex = 5;
            lblÖğrenciEkle.Text = "Öğrenci Ekle";
            // 
            // NumaraTxt
            // 
            NumaraTxt.Location = new Point(149, 226);
            NumaraTxt.Name = "NumaraTxt";
            NumaraTxt.Size = new Size(185, 27);
            NumaraTxt.TabIndex = 3;
            // 
            // lblEkleNumara
            // 
            lblEkleNumara.AutoSize = true;
            lblEkleNumara.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEkleNumara.Location = new Point(21, 229);
            lblEkleNumara.Name = "lblEkleNumara";
            lblEkleNumara.Size = new Size(117, 20);
            lblEkleNumara.TabIndex = 7;
            lblEkleNumara.Text = "Okul Numarası:";
            // 
            // lblFakulteSec
            // 
            lblFakulteSec.AutoSize = true;
            lblFakulteSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFakulteSec.Location = new Point(47, 293);
            lblFakulteSec.Name = "lblFakulteSec";
            lblFakulteSec.Size = new Size(91, 20);
            lblFakulteSec.TabIndex = 8;
            lblFakulteSec.Text = "Fakülte Seç:";
            // 
            // lblBolumSec
            // 
            lblBolumSec.AutoSize = true;
            lblBolumSec.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBolumSec.Location = new Point(52, 358);
            lblBolumSec.Name = "lblBolumSec";
            lblBolumSec.Size = new Size(86, 20);
            lblBolumSec.TabIndex = 9;
            lblBolumSec.Text = "Bölüm Seç:";
            // 
            // cmbBolum
            // 
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Location = new Point(149, 355);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(185, 28);
            cmbBolum.TabIndex = 10;
            // 
            // cmbFakulte
            // 
            cmbFakulte.FormattingEnabled = true;
            cmbFakulte.Location = new Point(149, 290);
            cmbFakulte.Name = "cmbFakulte";
            cmbFakulte.Size = new Size(185, 28);
            cmbFakulte.TabIndex = 11;
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(512, 500);
            Controls.Add(cmbFakulte);
            Controls.Add(cmbBolum);
            Controls.Add(lblBolumSec);
            Controls.Add(lblFakulteSec);
            Controls.Add(lblEkleNumara);
            Controls.Add(NumaraTxt);
            Controls.Add(lblÖğrenciEkle);
            Controls.Add(BtnÖğrenciEkle);
            Controls.Add(Soyadtxt);
            Controls.Add(Adtxt);
            Controls.Add(lblEkleAd);
            Controls.Add(lblEkleSoyad);
            Name = "OgrenciEkleForm";
            Text = "OgrenciEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEkleSoyad;
        private Label lblEkleAd;
        private TextBox Adtxt;
        private TextBox Soyadtxt;
        private Button BtnÖğrenciEkle;
        private Label lblÖğrenciEkle;
        private TextBox NumaraTxt;
        private Label lblEkleNumara;
        private Label lblFakulteSec;
        private Label lblBolumSec;
        private ComboBox cmbBolum;
        private ComboBox cmbFakulte;
    }
}