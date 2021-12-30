
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class FormHastaCagir
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.labelHasta = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(65, 62);
            this.comboBoxDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(572, 28);
            this.comboBoxDoktor.TabIndex = 0;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DOKTOR SEÇİNİZ :";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(702, 19);
            this.btnBasla.Margin = new System.Windows.Forms.Padding(4);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(139, 30);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(702, 62);
            this.btnDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(139, 30);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHasta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHasta.Location = new System.Drawing.Point(53, 196);
            this.labelHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(167, 67);
            this.labelHasta.TabIndex = 4;
            this.labelHasta.Text = "******";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3 adlı hastanın işlemi sürüyor";
            // 
            // FormHastaCagir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 395);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDoktor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHastaCagir";
            this.Text = "FormHastaCagir";
            this.Load += new System.EventHandler(this.FormHastaCagir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label labelHasta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}