namespace ÖğrenciKayıtSistemim.Formlar
{
    partial class BolumEkleForm
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
            btnBolumEkle = new Button();
            txtBolumAdi = new TextBox();
            lblBolum = new Label();
            SuspendLayout();
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBolumEkle.Location = new Point(220, 207);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(94, 57);
            btnBolumEkle.TabIndex = 5;
            btnBolumEkle.Text = "EKLE";
            btnBolumEkle.UseVisualStyleBackColor = true;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(90, 135);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(355, 27);
            txtBolumAdi.TabIndex = 4;
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBolum.Location = new Point(174, 61);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(179, 28);
            lblBolum.TabIndex = 3;
            lblBolum.Text = "Eklenecek Bölüm:";
            // 
            // BolumEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(545, 335);
            Controls.Add(btnBolumEkle);
            Controls.Add(txtBolumAdi);
            Controls.Add(lblBolum);
            Name = "BolumEkleForm";
            Text = "BolumEkleForm";
            Load += BolumEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBolumEkle;
        private TextBox txtBolumAdi;
        private Label lblBolum;
    }
}