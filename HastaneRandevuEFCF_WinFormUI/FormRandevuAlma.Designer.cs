﻿
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormRandevuAlma
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
            this.tabPageRandevuIslem = new System.Windows.Forms.TabPage();
            this.groupBoxRandevu = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBoxServis = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDoktorlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxServis = new System.Windows.Forms.ComboBox();
            this.groupBoxHasta = new System.Windows.Forms.GroupBox();
            this.listBoxHastalar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaTCArama = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuIslem.SuspendLayout();
            this.groupBoxRandevu.SuspendLayout();
            this.groupBoxServis.SuspendLayout();
            this.groupBoxHasta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuIslem);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1546, 733);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRandevuIslem
            // 
            this.tabPageRandevuIslem.BackColor = System.Drawing.Color.Linen;
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxRandevu);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxServis);
            this.tabPageRandevuIslem.Controls.Add(this.groupBoxHasta);
            this.tabPageRandevuIslem.Location = new System.Drawing.Point(4, 25);
            this.tabPageRandevuIslem.Name = "tabPageRandevuIslem";
            this.tabPageRandevuIslem.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRandevuIslem.Size = new System.Drawing.Size(1538, 704);
            this.tabPageRandevuIslem.TabIndex = 0;
            this.tabPageRandevuIslem.Text = "RANDEVU İŞLEMLERİ SAYFASI";
            // 
            // groupBoxRandevu
            // 
            this.groupBoxRandevu.Controls.Add(this.label4);
            this.groupBoxRandevu.Controls.Add(this.dateTimePickerRandevuTarihi);
            this.groupBoxRandevu.Location = new System.Drawing.Point(744, 35);
            this.groupBoxRandevu.Name = "groupBoxRandevu";
            this.groupBoxRandevu.Size = new System.Drawing.Size(565, 440);
            this.groupBoxRandevu.TabIndex = 1;
            this.groupBoxRandevu.TabStop = false;
            this.groupBoxRandevu.Text = "RANDEVU TARİH VE SAAT İŞLEMLERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "RANDEVU TARİHİ SEÇİN :";
            // 
            // dateTimePickerRandevuTarihi
            // 
            this.dateTimePickerRandevuTarihi.Location = new System.Drawing.Point(197, 47);
            this.dateTimePickerRandevuTarihi.Name = "dateTimePickerRandevuTarihi";
            this.dateTimePickerRandevuTarihi.Size = new System.Drawing.Size(212, 22);
            this.dateTimePickerRandevuTarihi.TabIndex = 0;
            this.dateTimePickerRandevuTarihi.ValueChanged += new System.EventHandler(this.dateTimePickerRandevuTarihi_ValueChanged);
            // 
            // groupBoxServis
            // 
            this.groupBoxServis.Controls.Add(this.label3);
            this.groupBoxServis.Controls.Add(this.listBoxDoktorlar);
            this.groupBoxServis.Controls.Add(this.label2);
            this.groupBoxServis.Controls.Add(this.comboBoxServis);
            this.groupBoxServis.Location = new System.Drawing.Point(426, 35);
            this.groupBoxServis.Name = "groupBoxServis";
            this.groupBoxServis.Size = new System.Drawing.Size(291, 440);
            this.groupBoxServis.TabIndex = 0;
            this.groupBoxServis.TabStop = false;
            this.groupBoxServis.Text = "SERVİS VE DOKTOR SEÇİMLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DOKTOR SEÇİN :";
            // 
            // listBoxDoktorlar
            // 
            this.listBoxDoktorlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxDoktorlar.FormattingEnabled = true;
            this.listBoxDoktorlar.ItemHeight = 16;
            this.listBoxDoktorlar.Location = new System.Drawing.Point(3, 129);
            this.listBoxDoktorlar.Name = "listBoxDoktorlar";
            this.listBoxDoktorlar.Size = new System.Drawing.Size(285, 308);
            this.listBoxDoktorlar.TabIndex = 2;
            this.listBoxDoktorlar.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktorlar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVİS SEÇİN :";
            // 
            // comboBoxServis
            // 
            this.comboBoxServis.FormattingEnabled = true;
            this.comboBoxServis.Location = new System.Drawing.Point(121, 48);
            this.comboBoxServis.Name = "comboBoxServis";
            this.comboBoxServis.Size = new System.Drawing.Size(164, 24);
            this.comboBoxServis.TabIndex = 0;
            this.comboBoxServis.SelectedIndexChanged += new System.EventHandler(this.comboBoxServis_SelectedIndexChanged);
            // 
            // groupBoxHasta
            // 
            this.groupBoxHasta.Controls.Add(this.listBoxHastalar);
            this.groupBoxHasta.Controls.Add(this.label1);
            this.groupBoxHasta.Controls.Add(this.txtHastaTCArama);
            this.groupBoxHasta.Location = new System.Drawing.Point(43, 35);
            this.groupBoxHasta.Name = "groupBoxHasta";
            this.groupBoxHasta.Size = new System.Drawing.Size(344, 440);
            this.groupBoxHasta.TabIndex = 0;
            this.groupBoxHasta.TabStop = false;
            this.groupBoxHasta.Text = "HASTA SEÇİM İŞLEMLERİ";
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.ItemHeight = 16;
            this.listBoxHastalar.Location = new System.Drawing.Point(3, 97);
            this.listBoxHastalar.Name = "listBoxHastalar";
            this.listBoxHastalar.Size = new System.Drawing.Size(338, 340);
            this.listBoxHastalar.TabIndex = 4;
            this.listBoxHastalar.SelectedIndexChanged += new System.EventHandler(this.listBoxHastalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA TC NO :";
            // 
            // txtHastaTCArama
            // 
            this.txtHastaTCArama.Location = new System.Drawing.Point(127, 44);
            this.txtHastaTCArama.Name = "txtHastaTCArama";
            this.txtHastaTCArama.Size = new System.Drawing.Size(198, 22);
            this.txtHastaTCArama.TabIndex = 2;
            this.txtHastaTCArama.TextChanged += new System.EventHandler(this.txtHastaTCArama_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1538, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormRandevuAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1365, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormRandevuAlma";
            this.Text = "RANDEVU ALMA İŞLEMLERİ FORMU";
            this.Load += new System.EventHandler(this.FormRandevuAlma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRandevuIslem.ResumeLayout(false);
            this.groupBoxRandevu.ResumeLayout(false);
            this.groupBoxRandevu.PerformLayout();
            this.groupBoxServis.ResumeLayout(false);
            this.groupBoxServis.PerformLayout();
            this.groupBoxHasta.ResumeLayout(false);
            this.groupBoxHasta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRandevuIslem;
        private System.Windows.Forms.GroupBox groupBoxRandevu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihi;
        private System.Windows.Forms.GroupBox groupBoxServis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxDoktorlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxServis;
        private System.Windows.Forms.GroupBox groupBoxHasta;
        private System.Windows.Forms.ListBox listBoxHastalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaTCArama;
        private System.Windows.Forms.TabPage tabPage2;
    }
}