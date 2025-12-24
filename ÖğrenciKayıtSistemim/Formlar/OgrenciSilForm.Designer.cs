namespace ÖğrenciKayıtSistemim.Formlar
{
    partial class OgrenciSilForm
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
            listViewOgrenciler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnYenile = new Button();
            btnSil = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(312, 25);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "Kayıtlı Öğrenciler";
            // 
            // listViewOgrenciler
            // 
            listViewOgrenciler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewOgrenciler.FullRowSelect = true;
            listViewOgrenciler.Location = new Point(12, 87);
            listViewOgrenciler.Name = "listViewOgrenciler";
            listViewOgrenciler.Size = new Size(774, 374);
            listViewOgrenciler.TabIndex = 1;
            listViewOgrenciler.UseCompatibleStateImageBehavior = false;
            listViewOgrenciler.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Seçim / No";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Fakülte";
            columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Bölüm";
            columnHeader5.Width = 170;
            // 
            // btnYenile
            // 
            btnYenile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYenile.Location = new Point(12, 495);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(124, 66);
            btnYenile.TabIndex = 2;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = true;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(662, 495);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(124, 66);
            btnSil.TabIndex = 3;
            btnSil.Text = "Öğrenciyi Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // OgrenciSilForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(798, 573);
            Controls.Add(btnSil);
            Controls.Add(btnYenile);
            Controls.Add(listViewOgrenciler);
            Controls.Add(label1);
            Name = "OgrenciSilForm";
            Text = "Öğrenci Silme Ekranı";
          //  Load += OgrenciSilForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewOgrenciler;
        private Button btnYenile;
        private Button btnSil;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}