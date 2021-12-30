
namespace HastaneRandevuEFCF_WinFormUI
{
    partial class UC_RandevuSaat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxSaatler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRandevuButonlar = new System.Windows.Forms.TableLayoutPanel();
            this.btn00 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn45 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelRandevuButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSaatler
            // 
            this.comboBoxSaatler.FormattingEnabled = true;
            this.comboBoxSaatler.Location = new System.Drawing.Point(3, 27);
            this.comboBoxSaatler.Name = "comboBoxSaatler";
            this.comboBoxSaatler.Size = new System.Drawing.Size(395, 24);
            this.comboBoxSaatler.TabIndex = 0;
            this.comboBoxSaatler.SelectedIndexChanged += new System.EventHandler(this.comboBoxSaatler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saat Seçin :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.10799F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSaatler, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(22, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.18182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.81818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(450, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelRandevuButonlar
            // 
            this.tableLayoutPanelRandevuButonlar.BackColor = System.Drawing.Color.LightSalmon;
            this.tableLayoutPanelRandevuButonlar.ColumnCount = 2;
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn00, 0, 0);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn30, 0, 1);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn45, 1, 1);
            this.tableLayoutPanelRandevuButonlar.Controls.Add(this.btn15, 1, 0);
            this.tableLayoutPanelRandevuButonlar.Location = new System.Drawing.Point(3, 89);
            this.tableLayoutPanelRandevuButonlar.Name = "tableLayoutPanelRandevuButonlar";
            this.tableLayoutPanelRandevuButonlar.RowCount = 2;
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanelRandevuButonlar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanelRandevuButonlar.Size = new System.Drawing.Size(486, 101);
            this.tableLayoutPanelRandevuButonlar.TabIndex = 4;
            // 
            // btn00
            // 
            this.btn00.Location = new System.Drawing.Point(3, 3);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(189, 42);
            this.btn00.TabIndex = 0;
            this.btn00.Text = "button1";
            this.btn00.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(3, 51);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(189, 45);
            this.btn30.TabIndex = 2;
            this.btn30.Text = "button3";
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn45
            // 
            this.btn45.Location = new System.Drawing.Point(246, 51);
            this.btn45.Name = "btn45";
            this.btn45.Size = new System.Drawing.Size(186, 45);
            this.btn45.TabIndex = 3;
            this.btn45.Text = "button4";
            this.btn45.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(246, 3);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(186, 42);
            this.btn15.TabIndex = 1;
            this.btn15.Text = "button2";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_RandevuSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelRandevuButonlar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_RandevuSaat";
            this.Size = new System.Drawing.Size(497, 203);
            this.Load += new System.EventHandler(this.UC_RandevuSaat_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelRandevuButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSaatler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRandevuButonlar;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn45;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Timer timer1;
    }
}
