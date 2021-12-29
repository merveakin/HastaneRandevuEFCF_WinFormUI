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

    }
}
