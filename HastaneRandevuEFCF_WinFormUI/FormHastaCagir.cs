using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_BLL;
using HastaneRandevuEFCF_Entities;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormHastaCagir : Form
    {
        public FormHastaCagir()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        DoktorManager drManager = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();
        Doktor SecilenDoktor { get; set; }

        private void FormHastaCagir_Load(object sender, EventArgs e)
        {
            //combo
            ComboyaDoktorlariGetir();
            //btnDurdur
            btnDurdur.Enabled = false;
            btnBasla.Enabled = true;
            //label
            labelHasta.Text = "**********";
            //doktor
            SecilenDoktor = null;
            //timer
            label3.Visible = false;
        }

        private void ComboyaDoktorlariGetir()
        {
            comboBoxDoktor.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxDoktor.ValueMember = "DoktorId";
            comboBoxDoktor.DataSource = drManager.TumAktifDoktorlariGetir();
            comboBoxDoktor.SelectedIndex = -1;

        }
        private void comboBoxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelHasta.Text = "---";
            if (comboBoxDoktor.SelectedIndex >= 0)
            {
                SecilenDoktor = drManager.DoktoruIdyeGoreBul(
                    (int)comboBoxDoktor.SelectedValue);

                if (rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now).Count == 0)
                {
                    MessageBox.Show($"{SecilenDoktor.ToString()} adlı doktorun bugün hiç randevusu bulunmuyor!");
                    timer1.Stop();
                    btnBasla.Enabled = true;
                    btnDurdur.Enabled = false;
                }

                //ÖDEV : SECİLEN DOKTORUN BUGÜNE AİT RANDEVUSU YOKSA BURADA BİR MBOX İLE RANDEVUSU YOKTUR DİYE MESAJ VERİLMELİDİR. VE TIMER STOP EDİLMELİDİR.
            }
        }
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;         //1 saniye verdik
            //Timer'in enable özelliği true olduğunda çalışır.
            timer1.Enabled = true;
            //timer'ı start() metodu ile de çalıştırabiliriz.
            //timer1.Start();

            btnDurdur.Enabled = true;
            btnBasla.Enabled = false;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnBasla.Enabled = true;
            btnDurdur.Enabled = false;
            labelHasta.Font = new Font("Arial", 35);
            //if (!labelHasta.Text.Contains("*"))
            //{
            //    labelHasta.Text += $"\n adlı hastanın işlemi sürüyor.";
            //}
            //label3.Visible = true;
            //label3.Text = "";
            //label3.Font = new Font("Arial",18);
            //label3.Text += $"adlı hastanın işlemi sürüyor...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Font BuyukFont = new Font("Arial", 45);
            Font NormalFont = new Font("Arial", 35);


            if (SecilenDoktor != null)
            {
                //Doktorun bugüne ait randevularını bulalım.
                List<RandevuBilgileri> drRandevulari =
                    rndManager.DoktorunRandevulariniTariheGoreGetir(SecilenDoktor, DateTime.Now);

                if (drRandevulari.Count > 0)
                {
                    RandevuBilgileri bulunanRandevu =
                        drRandevulari.FirstOrDefault(x => x.RandevuTarihi.ToString("HH") == DateTime.Now.Hour.ToString()
                        &&
                        x.RandevuTarihi.Minute < DateTime.Now.Minute + 2
                        &&
                        x.RandevuTarihi.Minute > DateTime.Now.Minute - 2);

                    if (bulunanRandevu != null)
                    {
                        labelHasta.Text = $"{bulunanRandevu.Hasta.HastaAdi} {bulunanRandevu.Hasta.HastaSoyadi}";



                        labelHasta.ForeColor = Color.Cyan;
                        if (DateTime.Now.Second % 2 == 0)
                        {
                            labelHasta.Font = BuyukFont;
                        }

                        //else if (DateTime.Now.Second % 3 == 0)
                        //{
                        //    labelHasta.Font = NormalFont;
                        //}

                        else
                        {
                            labelHasta.Font = NormalFont;
                        }

                    }
                }
            }
        }

    }
}
