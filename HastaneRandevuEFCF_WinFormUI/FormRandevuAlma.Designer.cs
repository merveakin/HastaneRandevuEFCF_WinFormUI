
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
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.UC_RandevuSaat1 = new HastaneRandevuEFCF_WinFormUI.UC_RandevuSaat();
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
            this.tabPageCiktiAl = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerCiktiAl = new System.Windows.Forms.DateTimePicker();
            this.btnCiktiAl = new System.Windows.Forms.Button();
            this.comboBoxCiktiAlDrSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.listViewAlinanRandevular = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPageRandevuIslem.SuspendLayout();
            this.groupBoxRandevu.SuspendLayout();
            this.groupBoxServis.SuspendLayout();
            this.groupBoxHasta.SuspendLayout();
            this.tabPageCiktiAl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRandevuIslem);
            this.tabControl1.Controls.Add(this.tabPageCiktiAl);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1546, 733);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageRandevuIslem
            // 
            this.tabPageRandevuIslem.BackColor = System.Drawing.Color.Linen;
            this.tabPageRandevuIslem.Controls.Add(this.listViewAlinanRandevular);
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
            this.groupBoxRandevu.Controls.Add(this.btnRandevuAl);
            this.groupBoxRandevu.Controls.Add(this.UC_RandevuSaat1);
            this.groupBoxRandevu.Controls.Add(this.label4);
            this.groupBoxRandevu.Controls.Add(this.dateTimePickerRandevuTarihi);
            this.groupBoxRandevu.Location = new System.Drawing.Point(747, 15);
            this.groupBoxRandevu.Name = "groupBoxRandevu";
            this.groupBoxRandevu.Size = new System.Drawing.Size(470, 424);
            this.groupBoxRandevu.TabIndex = 1;
            this.groupBoxRandevu.TabStop = false;
            this.groupBoxRandevu.Text = "RANDEVU TARİH VE SAAT İŞLEMLERİ";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.BackColor = System.Drawing.Color.Moccasin;
            this.btnRandevuAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuAl.Location = new System.Drawing.Point(9, 337);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(446, 39);
            this.btnRandevuAl.TabIndex = 3;
            this.btnRandevuAl.Text = "RANDEVUYU AL";
            this.btnRandevuAl.UseVisualStyleBackColor = false;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // UC_RandevuSaat1
            // 
            this.UC_RandevuSaat1.DisaridanGelenTarih = new System.DateTime(2021, 12, 29, 10, 6, 50, 84);
            this.UC_RandevuSaat1.Doktorum = null;
            this.UC_RandevuSaat1.Location = new System.Drawing.Point(6, 129);
            this.UC_RandevuSaat1.Name = "UC_RandevuSaat1";
            this.UC_RandevuSaat1.RandevuAlmaAktifMi = false;
            this.UC_RandevuSaat1.SecilenRandevuTarihi = new System.DateTime(((long)(0)));
            this.UC_RandevuSaat1.Size = new System.Drawing.Size(449, 202);
            this.UC_RandevuSaat1.TabIndex = 2;
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
            this.groupBoxServis.Location = new System.Drawing.Point(429, 15);
            this.groupBoxServis.Name = "groupBoxServis";
            this.groupBoxServis.Size = new System.Drawing.Size(291, 427);
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
            this.listBoxDoktorlar.Location = new System.Drawing.Point(3, 116);
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
            this.groupBoxHasta.Location = new System.Drawing.Point(46, 15);
            this.groupBoxHasta.Name = "groupBoxHasta";
            this.groupBoxHasta.Size = new System.Drawing.Size(344, 427);
            this.groupBoxHasta.TabIndex = 0;
            this.groupBoxHasta.TabStop = false;
            this.groupBoxHasta.Text = "HASTA SEÇİM İŞLEMLERİ";
            // 
            // listBoxHastalar
            // 
            this.listBoxHastalar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxHastalar.FormattingEnabled = true;
            this.listBoxHastalar.ItemHeight = 16;
            this.listBoxHastalar.Location = new System.Drawing.Point(3, 84);
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
            // tabPageCiktiAl
            // 
            this.tabPageCiktiAl.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPageCiktiAl.Controls.Add(this.label6);
            this.tabPageCiktiAl.Controls.Add(this.dateTimePickerCiktiAl);
            this.tabPageCiktiAl.Controls.Add(this.btnCiktiAl);
            this.tabPageCiktiAl.Controls.Add(this.comboBoxCiktiAlDrSec);
            this.tabPageCiktiAl.Controls.Add(this.label5);
            this.tabPageCiktiAl.Location = new System.Drawing.Point(4, 25);
            this.tabPageCiktiAl.Name = "tabPageCiktiAl";
            this.tabPageCiktiAl.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCiktiAl.Size = new System.Drawing.Size(1538, 704);
            this.tabPageCiktiAl.TabIndex = 1;
            this.tabPageCiktiAl.Text = "DR RANDEVU ÇIKTISI AL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "TARİH SEÇİNİZ :";
            // 
            // dateTimePickerCiktiAl
            // 
            this.dateTimePickerCiktiAl.Location = new System.Drawing.Point(419, 98);
            this.dateTimePickerCiktiAl.Name = "dateTimePickerCiktiAl";
            this.dateTimePickerCiktiAl.Size = new System.Drawing.Size(405, 22);
            this.dateTimePickerCiktiAl.TabIndex = 3;
            this.dateTimePickerCiktiAl.ValueChanged += new System.EventHandler(this.dateTimePickerCiktiAl_ValueChanged);
            // 
            // btnCiktiAl
            // 
            this.btnCiktiAl.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCiktiAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiktiAl.ForeColor = System.Drawing.Color.Brown;
            this.btnCiktiAl.Location = new System.Drawing.Point(419, 170);
            this.btnCiktiAl.Name = "btnCiktiAl";
            this.btnCiktiAl.Size = new System.Drawing.Size(405, 64);
            this.btnCiktiAl.TabIndex = 2;
            this.btnCiktiAl.Text = "ÇIKTI AL";
            this.btnCiktiAl.UseVisualStyleBackColor = false;
            this.btnCiktiAl.Click += new System.EventHandler(this.btnCiktiAl_Click);
            // 
            // comboBoxCiktiAlDrSec
            // 
            this.comboBoxCiktiAlDrSec.FormattingEnabled = true;
            this.comboBoxCiktiAlDrSec.Location = new System.Drawing.Point(419, 30);
            this.comboBoxCiktiAlDrSec.Name = "comboBoxCiktiAlDrSec";
            this.comboBoxCiktiAlDrSec.Size = new System.Drawing.Size(405, 24);
            this.comboBoxCiktiAlDrSec.TabIndex = 1;
            this.comboBoxCiktiAlDrSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxCiktiAlDrSec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "DOKTOR SEÇİNİZ :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // listViewAlinanRandevular
            // 
            this.listViewAlinanRandevular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listViewAlinanRandevular.FullRowSelect = true;
            this.listViewAlinanRandevular.GridLines = true;
            this.listViewAlinanRandevular.HideSelection = false;
            this.listViewAlinanRandevular.Location = new System.Drawing.Point(8, 445);
            this.listViewAlinanRandevular.Name = "listViewAlinanRandevular";
            this.listViewAlinanRandevular.Size = new System.Drawing.Size(1209, 189);
            this.listViewAlinanRandevular.TabIndex = 2;
            this.listViewAlinanRandevular.UseCompatibleStateImageBehavior = false;
            this.listViewAlinanRandevular.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doktor";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hasta";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Servis";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Randevu Tarihi";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // FormRandevuAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1224, 674);
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
            this.tabPageCiktiAl.ResumeLayout(false);
            this.tabPageCiktiAl.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageCiktiAl;
        private UC_RandevuSaat UC_RandevuSaat1;
        private System.Windows.Forms.Button btnRandevuAl;
        private System.Windows.Forms.Button btnCiktiAl;
        private System.Windows.Forms.ComboBox comboBoxCiktiAlDrSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerCiktiAl;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ListView listViewAlinanRandevular;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}