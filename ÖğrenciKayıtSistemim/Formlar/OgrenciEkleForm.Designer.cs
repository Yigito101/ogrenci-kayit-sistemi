namespace ÖğrenciKayıtSistemim.Formlar  // <-- BURAYI GÜNCELLEMEN YETERLİ
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Adtxt = new TextBox();
            Soyadtxt = new TextBox();
            NumaraTxt = new TextBox();
            BtnÖğrenciEkle = new Button();
            cmbFakulte = new ComboBox();
            cmbBolum = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(57, 107);
            label1.Name = "label1";
            label1.Size = new Size(46, 28);
            label1.TabIndex = 0;
            label1.Text = "AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(57, 153);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 1;
            label2.Text = "SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(57, 199);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 2;
            label3.Text = "NUMARA:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(57, 245);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 3;
            label4.Text = "FAKÜLTE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(57, 291);
            label5.Name = "label5";
            label5.Size = new Size(88, 28);
            label5.TabIndex = 4;
            label5.Text = "BÖLÜM:";
            // 
            // Adtxt
            // 
            Adtxt.Location = new Point(164, 111);
            Adtxt.Name = "Adtxt";
            Adtxt.Size = new Size(151, 27);
            Adtxt.TabIndex = 5;
            Adtxt.KeyPress += SadeceHarf_KeyPress;
            // 
            // Soyadtxt
            // 
            Soyadtxt.Location = new Point(164, 157);
            Soyadtxt.Name = "Soyadtxt";
            Soyadtxt.Size = new Size(151, 27);
            Soyadtxt.TabIndex = 6;
            Soyadtxt.KeyPress += SadeceHarf_KeyPress;
            // 
            // NumaraTxt
            // 
            NumaraTxt.Location = new Point(164, 203);
            NumaraTxt.Name = "NumaraTxt";
            NumaraTxt.Size = new Size(151, 27);
            NumaraTxt.TabIndex = 7;
            NumaraTxt.KeyPress += SadeceRakam_KeyPress;
            // 
            // BtnÖğrenciEkle
            // 
            BtnÖğrenciEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnÖğrenciEkle.Location = new Point(111, 355);
            BtnÖğrenciEkle.Name = "BtnÖğrenciEkle";
            BtnÖğrenciEkle.Size = new Size(149, 74);
            BtnÖğrenciEkle.TabIndex = 10;
            BtnÖğrenciEkle.Text = "EKLE";
            BtnÖğrenciEkle.UseVisualStyleBackColor = true;
            BtnÖğrenciEkle.Click += BtnÖğrenciEkle_Click;
            // 
            // cmbFakulte
            // 
            cmbFakulte.FormattingEnabled = true;
            cmbFakulte.Location = new Point(164, 249);
            cmbFakulte.Name = "cmbFakulte";
            cmbFakulte.Size = new Size(151, 28);
            cmbFakulte.TabIndex = 11;
            // 
            // cmbBolum
            // 
            cmbBolum.FormattingEnabled = true;
            cmbBolum.Location = new Point(164, 295);
            cmbBolum.Name = "cmbBolum";
            cmbBolum.Size = new Size(151, 28);
            cmbBolum.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(81, 31);
            label6.Name = "label6";
            label6.Size = new Size(244, 35);
            label6.TabIndex = 13;
            label6.Text = "Öğrenci Kayıt Ekranı";
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(380, 473);
            Controls.Add(label6);
            Controls.Add(cmbBolum);
            Controls.Add(cmbFakulte);
            Controls.Add(BtnÖğrenciEkle);
            Controls.Add(NumaraTxt);
            Controls.Add(Soyadtxt);
            Controls.Add(Adtxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkleForm";
            Text = "OgrenciEkleForm";
           // Load += OgrenciEkleForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Adtxt;
        private TextBox Soyadtxt;
        private TextBox NumaraTxt;
        private Button BtnÖğrenciEkle;
        private ComboBox cmbFakulte;
        private ComboBox cmbBolum;
        private Label label6;
    }
}