namespace ÖğrenciKayıtSistemim
{
    partial class girisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kullaniciTxt = new TextBox();
            parolaTxt = new TextBox();
            kullaniciLbl = new Label();
            parolaLbl = new Label();
            girisBtn = new Button();
            girisyaplbl = new Label();
            SuspendLayout();
            // 
            // kullaniciTxt
            // 
            kullaniciTxt.Location = new Point(232, 141);
            kullaniciTxt.Name = "kullaniciTxt";
            kullaniciTxt.Size = new Size(172, 27);
            kullaniciTxt.TabIndex = 0;
            // 
            // parolaTxt
            // 
            parolaTxt.Location = new Point(232, 197);
            parolaTxt.Name = "parolaTxt";
            parolaTxt.PasswordChar = '*';
            parolaTxt.Size = new Size(172, 27);
            parolaTxt.TabIndex = 1;
            // 
            // kullaniciLbl
            // 
            kullaniciLbl.AutoSize = true;
            kullaniciLbl.BorderStyle = BorderStyle.FixedSingle;
            kullaniciLbl.FlatStyle = FlatStyle.Flat;
            kullaniciLbl.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            kullaniciLbl.ForeColor = SystemColors.ButtonHighlight;
            kullaniciLbl.Location = new Point(88, 145);
            kullaniciLbl.Name = "kullaniciLbl";
            kullaniciLbl.Size = new Size(112, 21);
            kullaniciLbl.TabIndex = 2;
            kullaniciLbl.Text = "Kullanıcı Adı:";
            // 
            // parolaLbl
            // 
            parolaLbl.AutoSize = true;
            parolaLbl.BorderStyle = BorderStyle.FixedSingle;
            parolaLbl.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            parolaLbl.ForeColor = SystemColors.ButtonHighlight;
            parolaLbl.Location = new Point(133, 201);
            parolaLbl.Name = "parolaLbl";
            parolaLbl.Size = new Size(67, 21);
            parolaLbl.TabIndex = 3;
            parolaLbl.Text = "Parola:";
            parolaLbl.Click += label2_Click;
            // 
            // girisBtn
            // 
            girisBtn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            girisBtn.ForeColor = SystemColors.ActiveCaptionText;
            girisBtn.Location = new Point(232, 253);
            girisBtn.Name = "girisBtn";
            girisBtn.Size = new Size(94, 29);
            girisBtn.TabIndex = 4;
            girisBtn.Text = "Giris";
            girisBtn.UseVisualStyleBackColor = true;
            girisBtn.Click += girisBtn_Click;
            // 
            // girisyaplbl
            // 
            girisyaplbl.AutoSize = true;
            girisyaplbl.BackColor = Color.Transparent;
            girisyaplbl.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            girisyaplbl.ForeColor = SystemColors.ActiveCaptionText;
            girisyaplbl.Location = new Point(200, 82);
            girisyaplbl.Name = "girisyaplbl";
            girisyaplbl.Size = new Size(126, 28);
            girisyaplbl.TabIndex = 5;
            girisyaplbl.Text = "Giriş Yapınız";
            // 
            // girisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(537, 407);
            Controls.Add(girisyaplbl);
            Controls.Add(girisBtn);
            Controls.Add(parolaLbl);
            Controls.Add(kullaniciLbl);
            Controls.Add(parolaTxt);
            Controls.Add(kullaniciTxt);
            Name = "girisForm";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kullaniciTxt;
        private TextBox parolaTxt;
        private Label kullaniciLbl;
        private Label parolaLbl;
        private Button girisBtn;
        private Label girisyaplbl;
    }
}
