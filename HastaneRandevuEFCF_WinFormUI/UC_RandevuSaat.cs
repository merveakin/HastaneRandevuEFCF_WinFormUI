using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneRandevuEFCF_Entities;
using HastaneRandevuEFCF_BLL;

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class UC_RandevuSaat : UserControl
    {
        public UC_RandevuSaat()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        public Doktor Doktorum { get; set; }
        public DateTime DisaridanGelenTarih { get; set; } = DateTime.Now;
        RandevuManager rndManager = new RandevuManager();
        public DateTime SecilenRandevuTarihi { get; set; }
        public bool RandevuAlmaAktifMi { get; set; }

        private void UC_RandevuSaat_Load(object sender, EventArgs e)
        {
            RandevuAlmaAktifMi = false;
            comboBoxSaatler.DisplayMember = "SaatDilimi";
            comboBoxSaatler.ValueMember = "Id";
            comboBoxSaatler.DataSource = SaatViewModel.SaatlerListesiniGetir();
            comboBoxSaatler.SelectedIndex = -1;
            RandevuButonlarinIsimleriniTemizle();

            //butonlara ortak click event verildi.
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Click += new EventHandler(btnClick);
            }

            Doktorum = null;
            DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap();
        }

        private void RandevuButonlarinIsimleriniTemizle()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Text = "---";
            }
        }

        private void comboBoxSaatler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Doktorum == null)
                {
                    RandevuButonlariniPasiflestir();
                    return;
                }

                if (comboBoxSaatler.SelectedIndex >= 0)
                {
                    //1.ADIM ----->> Butonların textleri ayarlanacak
                    ButonlarinTextleriniAyarla();
                    //2.ADIM ----->> Butonların aktif pasiflik durumları ayarlanacak
                    DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap();
                }

                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message); ;
            }

        }

        private void DRveTrhyeGoreButonlariniAktifPasifIslemleriniYap()
        {
            try
            {
                RandevuButonlariniAktiflestir();
                if (Doktorum != null)
                {
                    //Randevuları alalım.
                    List<RandevuBilgileri> drRandevulari = rndManager.DoktorunRandevulariniTariheGoreGetir(Doktorum, DisaridanGelenTarih);

                    if (drRandevulari.Count > 0)
                    {
                        //randevuları tek tek dolaşalım pasifleştirme işlemlerimizi yapalım.
                        foreach (RandevuBilgileri item in drRandevulari)
                        {
                            if (item.RandevuTarihi.ToShortTimeString().Substring(0,2) == comboBoxSaatler.Text.Substring(0, 2))  //10:00 == 10:00
                            {
                                string itemsaatim = item.RandevuTarihi.ToShortTimeString();
                                string itemdk = itemsaatim.Substring(3, 2); //sadece dk yi aldık.

                                switch (itemdk)
                                {
                                    case "00":
                                        btn00.Enabled = false;
                                        break;
                                    case "15":
                                        btn15.Enabled = false;
                                        break;
                                    case "30":
                                        btn30.Enabled = false;
                                        break;
                                    case "45":
                                        btn45.Enabled = false;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }

                else
                {
                    RandevuButonlarinIsimleriniTemizle();
                    RandevuButonlariniPasiflestir();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void ButonlarinTextleriniAyarla()
        {
            if (comboBoxSaatler.SelectedIndex >= 0)
            {
                string saatim = SaatViewModel.SaatlerListesiniGetir().FirstOrDefault(x => x.Id == (int)comboBoxSaatler.SelectedValue).SaatDilimi.Substring(0, 2); //09
                foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
                {

                    switch (item.Name)
                    {
                        case "btn00":
                            btn00.Text = $"{saatim}:00";    //09:00
                            break;
                        case "btn15":
                            btn15.Text = $"{saatim}:15";    //09:15
                            break;
                        case "btn30":
                            btn30.Text = $"{saatim}:30";    //09:30
                            break;
                        case "btn45":
                            btn45.Text = $"{saatim}:45";    //09:45
                            break;
                        default:
                            item.Text = "---";
                            break;

                    }
                }
            }

            else
            {

            }
        }
        private void RandevuButonlariniAktiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Enabled = true;
            }
        }
        private void RandevuButonlariniPasiflestir()
        {
            foreach (Button item in tableLayoutPanelRandevuButonlar.Controls)
            {
                item.Enabled = false;
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            //Tıklandığında randevu tarihi oluşacak
            //09:00
            Button btn = sender as Button;
            int saat = Convert.ToInt32(btn.Text.Substring(0, 2));
            int dakika = Convert.ToInt32(btn.Text.Substring(3, 2));

            SecilenRandevuTarihi = new DateTime(DisaridanGelenTarih.Year, DisaridanGelenTarih.Month, DisaridanGelenTarih.Day, saat, dakika, 00);
            RandevuAlmaAktifMi = true;
            MessageBox.Show("Saati seçitiniz...RAndevu Al işlemine devam edebilirsiniz...");

        }

        public void Temizle()
        {
            comboBoxSaatler.SelectedIndex = -1;
            RandevuButonlarinIsimleriniTemizle();
            RandevuButonlariniPasiflestir();
            RandevuAlmaAktifMi = false;
        }
    }
}
