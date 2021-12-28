
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormDoktorlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageListele = new System.Windows.Forms.TabPage();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.tabPageDrEkle = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDrTc = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxDrTel = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxDrBranslar = new System.Windows.Forms.ComboBox();
            this.btnDrEkle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageListele.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.tabPageDrEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageListele);
            this.tabControl1.Controls.Add(this.tabPageDrEkle);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(867, 533);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageListele
            // 
            this.tabPageListele.Controls.Add(this.dataGridViewDoktor);
            this.tabPageListele.Location = new System.Drawing.Point(4, 25);
            this.tabPageListele.Name = "tabPageListele";
            this.tabPageListele.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListele.Size = new System.Drawing.Size(1598, 723);
            this.tabPageListele.TabIndex = 0;
            this.tabPageListele.Text = "Dr. Listesi";
            this.tabPageListele.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AllowUserToAddRows = false;
            this.dataGridViewDoktor.AllowUserToDeleteRows = false;
            this.dataGridViewDoktor.AllowUserToOrderColumns = true;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.ReadOnly = true;
            this.dataGridViewDoktor.RowHeadersWidth = 51;
            this.dataGridViewDoktor.RowTemplate.Height = 24;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(1592, 717);
            this.dataGridViewDoktor.TabIndex = 0;
            // 
            // tabPageDrEkle
            // 
            this.tabPageDrEkle.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPageDrEkle.Controls.Add(this.btnDrEkle);
            this.tabPageDrEkle.Controls.Add(this.comboBoxDrBranslar);
            this.tabPageDrEkle.Controls.Add(this.maskedTextBoxDrTel);
            this.tabPageDrEkle.Controls.Add(this.label11);
            this.tabPageDrEkle.Controls.Add(this.txtDrEmail);
            this.tabPageDrEkle.Controls.Add(this.txtDrSoyad);
            this.tabPageDrEkle.Controls.Add(this.txtDrAd);
            this.tabPageDrEkle.Controls.Add(this.txtDrTc);
            this.tabPageDrEkle.Controls.Add(this.label10);
            this.tabPageDrEkle.Controls.Add(this.label9);
            this.tabPageDrEkle.Controls.Add(this.label8);
            this.tabPageDrEkle.Controls.Add(this.label7);
            this.tabPageDrEkle.Controls.Add(this.label6);
            this.tabPageDrEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPageDrEkle.Name = "tabPageDrEkle";
            this.tabPageDrEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrEkle.Size = new System.Drawing.Size(859, 504);
            this.tabPageDrEkle.TabIndex = 1;
            this.tabPageDrEkle.Text = "Dr. Ekle";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(33, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "EMAİL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(33, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "TELEFONU :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(33, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "SOYADI  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(33, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "ADI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(33, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "TC NUMARASI :";
            // 
            // txtDrTc
            // 
            this.txtDrTc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDrTc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDrTc.Location = new System.Drawing.Point(248, 38);
            this.txtDrTc.Name = "txtDrTc";
            this.txtDrTc.Size = new System.Drawing.Size(562, 22);
            this.txtDrTc.TabIndex = 5;
            // 
            // txtDrAd
            // 
            this.txtDrAd.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDrAd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDrAd.Location = new System.Drawing.Point(248, 102);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(562, 22);
            this.txtDrAd.TabIndex = 6;
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDrSoyad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDrSoyad.Location = new System.Drawing.Point(248, 164);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(562, 22);
            this.txtDrSoyad.TabIndex = 7;
            // 
            // txtDrEmail
            // 
            this.txtDrEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDrEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDrEmail.Location = new System.Drawing.Point(248, 351);
            this.txtDrEmail.Name = "txtDrEmail";
            this.txtDrEmail.Size = new System.Drawing.Size(562, 22);
            this.txtDrEmail.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(33, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "BRANŞI  :";
            // 
            // maskedTextBoxDrTel
            // 
            this.maskedTextBoxDrTel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.maskedTextBoxDrTel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maskedTextBoxDrTel.Location = new System.Drawing.Point(248, 290);
            this.maskedTextBoxDrTel.Name = "maskedTextBoxDrTel";
            this.maskedTextBoxDrTel.Size = new System.Drawing.Size(562, 22);
            this.maskedTextBoxDrTel.TabIndex = 11;
            // 
            // comboBoxDrBranslar
            // 
            this.comboBoxDrBranslar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBoxDrBranslar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxDrBranslar.FormattingEnabled = true;
            this.comboBoxDrBranslar.Location = new System.Drawing.Point(248, 226);
            this.comboBoxDrBranslar.Name = "comboBoxDrBranslar";
            this.comboBoxDrBranslar.Size = new System.Drawing.Size(562, 24);
            this.comboBoxDrBranslar.TabIndex = 12;
            // 
            // btnDrEkle
            // 
            this.btnDrEkle.BackColor = System.Drawing.Color.Bisque;
            this.btnDrEkle.Location = new System.Drawing.Point(248, 419);
            this.btnDrEkle.Name = "btnDrEkle";
            this.btnDrEkle.Size = new System.Drawing.Size(220, 58);
            this.btnDrEkle.TabIndex = 13;
            this.btnDrEkle.Text = "YENİ DOKTOR EKLE";
            this.btnDrEkle.UseVisualStyleBackColor = false;
            this.btnDrEkle.Click += new System.EventHandler(this.btnDrEkle_Click);
            // 
            // FormDoktorlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 533);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDoktorlar";
            this.Text = "DOKTOR İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormDoktorlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageListele.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.tabPageDrEkle.ResumeLayout(false);
            this.tabPageDrEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageListele;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.TabPage tabPageDrEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDrBranslar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDrTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDrEmail;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.TextBox txtDrTc;
        private System.Windows.Forms.Button btnDrEkle;
    }
}