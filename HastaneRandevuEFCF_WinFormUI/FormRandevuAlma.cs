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
    public partial class FormRandevuAlma : Form
    {
        public FormRandevuAlma()
        {
            InitializeComponent();
        }

        //GLOBAL ALAN
        HastaManager hastaManagerim = new HastaManager();
        DoktorManager doktorManagerim = new DoktorManager();
        RandevuManager rndManager = new RandevuManager();

        private void FormRandevuAlma_Load(object sender, EventArgs e)
        {
            //Servis groupBox ve TarihSaat groupBoxları pasif
            ServisGroupBoxiniPasiflestir();
            RandevuTarihveSaatGroupBoxiniPasiflestir();
            HastaListBoxiniDoldur();
            //datetimepicker'ı formatlayalım.
            DateTimePickeriAyarla(DateTime.Now);

            //comboCiktiAl
            DoktorlariComboBoxCiktiAlDrSeceDoldur();

        }

        private void DoktorlariComboBoxCiktiAlDrSeceDoldur()
        {
            //
            comboBoxCiktiAlDrSec.DisplayMember = "DoktorAdi" + "DoktorSoyadi";
            comboBoxCiktiAlDrSec.ValueMember = "DoktorId";
            comboBoxCiktiAlDrSec.DataSource = doktorManagerim.TumAktifDoktorlariGetir();

        }

        private void DateTimePickeriAyarla(DateTime trh)
        {
            dateTimePickerRandevuTarihi.Format =
                         DateTimePickerFormat.Custom;
            dateTimePickerRandevuTarihi.CustomFormat = "dd.MM.yyyy";
            dateTimePickerRandevuTarihi.MinDate = trh;
            dateTimePickerRandevuTarihi.MaxDate =
                dateTimePickerRandevuTarihi.MinDate.AddDays(15);
            dateTimePickerRandevuTarihi.Value = trh;

            //
            dateTimePickerCiktiAl.Format = DateTimePickerFormat.Custom;
            dateTimePickerCiktiAl.CustomFormat = "dd.MM.yyyy";
            dateTimePickerCiktiAl.MinDate = DateTime.Now;
            dateTimePickerCiktiAl.MaxDate = dateTimePickerCiktiAl.MinDate.AddDays(15);
            dateTimePickerCiktiAl.Value = DateTime.Now;


        }

        private void HastaListBoxiniDoldur()
        {
            listBoxHastalar.DataSource = hastaManagerim.TumHastalariGetir();
            listBoxHastalar.SelectedIndex = -1;

        }

        private void RandevuTarihveSaatGroupBoxiniPasiflestir()
        {
            groupBoxRandevu.Enabled = false;
        }
        private void RandevuTarihveSaatGroupBoxiniAktiflestir()
        {
            groupBoxRandevu.Enabled = true;
        }
        private void ServisGroupBoxiniPasiflestir()
        {
            groupBoxServis.Enabled = false;
        }

        private void txtHastaTCArama_TextChanged(object sender, EventArgs e)
        {
            if (txtHastaTCArama.Text.Trim().Length >= 2)
            {
                listBoxHastalar.DataSource = hastaManagerim.TcNumarasinaGoreHastayiBul(txtHastaTCArama.Text);

            }

            else
            {
                HastaListBoxiniDoldur();
            }
        }
        private void listBoxHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHastalar.SelectedIndex >= 0)
            {
                ServisGroupBoxiniAktiflestir();
            }

            else
            {
                UC_RandevuSaat1.Doktorum = null;
                ServisGroupBoxiniPasiflestir();
                RandevuTarihveSaatGroupBoxiniPasiflestir();
            }
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }
        private void ServisGroupBoxiniAktiflestir()
        {
            groupBoxServis.Enabled = true;
            //servis combo dolmalı.
            ComboBoxServisiDoldur();
        }
        private void ComboBoxServisiDoldur()
        {
            comboBoxServis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServis.DataSource = Enum.GetValues(typeof(Branslar));
            comboBoxServis.SelectedIndex = 0;       //-1 yazsaydı boş gelecekti //0 olduğu için 'Branş Yok' gelecek
        }

        private void comboBoxServis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServis.SelectedIndex >= 0)
            {

                DoktorlarListesiniDoldur();
            }
            else
            {
                RandevuTarihveSaatGroupBoxiniPasiflestir();
                listBoxDoktorlar.DataSource = null;
                //doktorManagerim.TumAktifDoktorlariGetir();
            }
            listBoxDoktorlar.SelectedIndex = -1;
            DateTimePickeriAyarla(DateTime.Now);
            UC_RandevuSaat1.Temizle();
        }

        private void DoktorlarListesiniDoldur()
        {
            Branslar drBransi;
            Enum.TryParse(comboBoxServis.SelectedValue.ToString(), out drBransi);
            listBoxDoktorlar.DataSource =
                doktorManagerim.BransaGoreDoktorlariGetir(drBransi);
        }

        private void listBoxDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(DateTime.Now);

            if (listBoxDoktorlar.SelectedIndex >= 0)
            {
                RandevuTarihveSaatGroupBoxiniAktiflestir();
                Doktor seciliDr = listBoxDoktorlar.SelectedItem as Doktor;
                UC_RandevuSaat1.Doktorum = seciliDr;

            }
            else
            {
                RandevuTarihveSaatGroupBoxiniPasiflestir();
                UC_RandevuSaat1.Doktorum = null;
            }
        }
        private void dateTimePickerRandevuTarihi_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickeriAyarla(dateTimePickerRandevuTarihi.Value);
            UC_RandevuSaat1.DisaridanGelenTarih = dateTimePickerRandevuTarihi.Value;
            UC_RandevuSaat1.Temizle();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBoxHastalar.SelectedIndex < 0)
                {
                    MessageBox.Show("Hasta seçmeden randevu işlemleri yapılamaz!");
                    return;
                }
                if (listBoxDoktorlar.SelectedIndex < 0)
                {
                    throw new Exception("Doktor seçmeden randevu alma işlemleri yapılamaz!");
                }

                if (!UC_RandevuSaat1.RandevuAlmaAktifMi)
                {
                    MessageBox.Show("Randevu alabilmeniz için yukarıdaki randevu saati butonlarına tıklayarak saat seçmelisiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //Hastanın o tarihe ve o saate başka randevusu varsa randevuyu alamaz.

                Hasta secilenHasta = listBoxHastalar.SelectedItem as Hasta;

                //dikkat etmeliyiz.
                if (rndManager.HastaninSecilenTarihveSaatteRandevusuVarMi(secilenHasta, UC_RandevuSaat1.SecilenRandevuTarihi))
                {
                    MessageBox.Show($"DİKKAT! : {UC_RandevuSaat1.SecilenRandevuTarihi.ToString("dd.MM.yyyy HH:mm:ss")} başka bir randevunuz vardır. Bu nedenle aynı saate randevu alamazsınız!", "UYARI : ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                //if'i geçerse hasta randevusunu alabilir.
                Doktor secilenDoktor = listBoxDoktorlar.SelectedItem as Doktor;
                RandevuBilgileri yeniRandevu = new RandevuBilgileri()
                {
                    HastaId = secilenHasta.HastaId,
                    DoktorId = secilenDoktor.DoktorId,
                    RandevuTarihi = UC_RandevuSaat1.SecilenRandevuTarihi
                };

                bool rndAlindiMi = false;
                rndAlindiMi = rndManager.RandevuyuAl(yeniRandevu);
                if (rndAlindiMi)
                {
                    MessageBox.Show($"RANDEVUNUZ ALINMIŞTIR!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Alınan randevuyu listviewe ekleyelim.
                    ListVieweRandevuyuEkle(yeniRandevu);

                    //TEMİZLİK
                    UC_RandevuSaat1.Temizle();
                    //  dateTimePickerRandevuTarihi.Value = DateTime.Now;
                    RandevuTarihveSaatGroupBoxiniPasiflestir();
                    comboBoxServis.SelectedIndex = -1;
                    listBoxDoktorlar.SelectedIndex = -1;
                    ServisGroupBoxiniPasiflestir();
                    listBoxHastalar.SelectedIndex = -1;
                }
                else
                {
                    throw new Exception("Randevu alma işleminde beklenmedik bir hata oluştu!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void ListVieweRandevuyuEkle(RandevuBilgileri yeniRandevu)
        {
            RandevuBilgileriViewModel randevu = rndManager.RandevuyuViewModeleAktar(yeniRandevu);
            ListViewItem li = new ListViewItem();
            li.Text = randevu.Servis;
            li.SubItems.Add(randevu.DoktorAdSoyad);
            li.SubItems.Add(randevu.HastaAdSoyad);
            li.SubItems.Add(randevu.RandevuTarihi.ToString("dd.MM.yyyy HH:mm"));
            li.Tag = randevu;
            listViewAlinanRandevular.Items.Add(li);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //temizlik randevu al
            UC_RandevuSaat1.Temizle();
            RandevuTarihveSaatGroupBoxiniAktiflestir();
            comboBoxServis.SelectedIndex = -1;
            listBoxDoktorlar.SelectedIndex = -1;
            txtHastaTCArama.Clear();        //*****
            ServisGroupBoxiniPasiflestir();
            listBoxHastalar.SelectedIndex = -1;

            //temizlik çıktı al
            btnCiktiAl.Enabled = false;
            dateTimePickerCiktiAl.Value = DateTime.Now;
            comboBoxCiktiAlDrSec.SelectedIndex = 0;
        }
        private void comboBoxCiktiAlDrSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCiktiAlDrSec.SelectedIndex < 0)
                {
                    throw new Exception("Lütfen doktor seçiniz!");
                }
                Doktor secilenDr = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                CiktiAlButonuAktifPasifliginiAyarla(secilenDr, dateTimePickerCiktiAl.Value);
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message);
            }
        }
        private void CiktiAlButonuAktifPasifliginiAyarla(Doktor dr, DateTime tarih)
        {
            btnCiktiAl.Enabled = false;
            btnCiktiAl.BackColor = SystemColors.Control;
            if (dr != null)
            {
                List<RandevuBilgileri> rndList = rndManager.DoktorunRandevulariniTariheGoreGetir(dr, tarih);
                if (rndList.Count > 0)
                {
                    btnCiktiAl.Enabled = true;
                    btnCiktiAl.BackColor = Color.Pink;
                }
                else
                {
                    MessageBox.Show($"{dr.ToString()} adlı doktorun {tarih.ToString("dd.MM.yyyy")} tarihine ait randevusu yoktur. Başka tarih seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
        private void dateTimePickerCiktiAl_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxCiktiAlDrSec.SelectedIndex >= 0)
            {
                Doktor secilenDr = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                CiktiAlButonuAktifPasifliginiAyarla(secilenDr, dateTimePickerCiktiAl.Value);
            }
        }
        private void btnCiktiAl_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
                btnCiktiAl.BackColor = SystemColors.Control;
                btnCiktiAl.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Doktor doktorum = doktorManagerim.DoktoruIdyeGoreBul((int)comboBoxCiktiAlDrSec.SelectedValue);
                Bitmap bmp1 = Properties.Resources.doktorRandevularResim1;
                Image resim1 = bmp1;

                Bitmap bmp2 = Properties.Resources.doktorRandevularResim2;
                Image resim2 = bmp2;

                e.Graphics.DrawImage(resim1, 25, 25, resim1.Width / 10, resim1.Height / 10);
                e.Graphics.DrawImage(resim2, 725, 25, resim2.Width / 10, resim2.Height / 10);

                e.Graphics.DrawString($"{EnumManager.BransiTurkceStringOlarakVer(doktorum.Brans)} - {doktorum.ToString()} - {dateTimePickerCiktiAl.Value.ToString("dd.MM.yyyy")} Tarihine Ait Randevular", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));

                e.Graphics.DrawString("Tarih ve Saat", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));

                e.Graphics.DrawString("Hasta Adı Soyadı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));

                e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));

                Point konumTarih = new Point(50, 235);
                Point konumHasta = new Point(200, 235);

                string[] saatler = { "09:00", "09:15", "09:30", "09:45",
                    "10:00","10:15","10:30","10:45",
                    "11:00","11:15","11:30","11:45",
                    "13:00","13:15","13:30","13:45",
                    "14:00","14:15","14:30","14:45",
                    "15:00","15:15","15:30","15:45" };

                RandevuBilgileri[] siraliRandevular = new RandevuBilgileri[saatler.Length];


                List<RandevuBilgileri> drRandevular = rndManager.DoktorunRandevulariniTariheGoreGetir(doktorum, dateTimePickerCiktiAl.Value);

                foreach (RandevuBilgileri item in drRandevular)
                {
                    for (int i = 0; i < saatler.Length; i++)
                    {
                        if (saatler[i]==item.RandevuTarihi.ToString("HH:mm"))
                        {
                            siraliRandevular[i] = item;
                        }
                    }
                }

                foreach (RandevuBilgileri item in siraliRandevular)
                {
                    if (item != null)
                    {
                        konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);

                        e.Graphics.DrawString($"{item.RandevuTarihi.ToString("dd.MM.yyyy")} - " + $"{item.RandevuTarihi.ToString("HH:mm")}", new Font("Arial", 10, FontStyle.Regular),
                            Brushes.Black,konumTarih);

                        konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                        e.Graphics.DrawString($"{item.Hasta.HastaAdi} {item.Hasta.HastaSoyadi}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA : " + ex.Message);
            }
        }
    }
}
