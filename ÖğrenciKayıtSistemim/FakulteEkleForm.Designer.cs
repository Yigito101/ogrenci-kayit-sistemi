namespace ÖğrenciKayıtSistemim
{
    partial class FakulteEkleForm
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
            lblFakulte = new Label();
            txtFakulteAdi = new TextBox();
            btnFakulteEkle = new Button();
            SuspendLayout();
            // 
            // lblFakulte
            // 
            lblFakulte.AutoSize = true;
            lblFakulte.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFakulte.Location = new Point(169, 36);
            lblFakulte.Name = "lblFakulte";
            lblFakulte.Size = new Size(187, 28);
            lblFakulte.TabIndex = 0;
            lblFakulte.Text = "Eklenecek Fakülte:";
            // 
            // txtFakulteAdi
            // 
            txtFakulteAdi.Location = new Point(85, 110);
            txtFakulteAdi.Name = "txtFakulteAdi";
            txtFakulteAdi.Size = new Size(355, 27);
            txtFakulteAdi.TabIndex = 1;
            // 
            // btnFakulteEkle
            // 
            btnFakulteEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFakulteEkle.Location = new Point(215, 182);
            btnFakulteEkle.Name = "btnFakulteEkle";
            btnFakulteEkle.Size = new Size(94, 57);
            btnFakulteEkle.TabIndex = 2;
            btnFakulteEkle.Text = "EKLE";
            btnFakulteEkle.UseVisualStyleBackColor = true;
            btnFakulteEkle.Click += btnFakulteEkle_Click;
            // 
            // FakulteEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(532, 304);
            Controls.Add(btnFakulteEkle);
            Controls.Add(txtFakulteAdi);
            Controls.Add(lblFakulte);
            Name = "FakulteEkleForm";
            Text = "FakulteEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFakulte;
        private TextBox txtFakulteAdi;
        private Button btnFakulteEkle;
    }
}