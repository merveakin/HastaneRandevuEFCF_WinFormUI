using HastaneRandevuEFCF_Entities;
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

namespace HastaneRandevuEFCF_WinFormUI
{
    public partial class FormDoktorlar : Form
    {
        public FormDoktorlar()
        {
            InitializeComponent();
        }

        //GLOBAL ALAN
        DoktorManager drManager = new DoktorManager();
        


        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            //datagrid
            DrGrideVerileriGetir();

            //COMBOBOX
            comboBoxDrBranslar.DropDownStyle = ComboBoxStyle.DropDownList;
            //comboBoxDrBranslar.DisplayMember = "TheValue";
            //comboBoxDrBranslar.ValueMember = "TheKey";
            //comboBoxDrBranslar.DataSource = EnumManager.TumBranslariGetir();
            //comboBoxDrBranslar.SelectedValue = (int)Branslar.BransYok;

            comboBoxDrBranslar.DataSource = Enum.GetValues(typeof(Branslar));

            //maskedtextbox maske ayarlanması
            maskedTextBoxDrTel.Mask = @"\0\5##-###-##-##";

        }
        private void btnDrEkle_Click(object sender, EventArgs e)
        {
            Branslar drBransi;
            Enum.TryParse(comboBoxDrBranslar.SelectedValue.ToString(), out drBransi);

            try
            {
                //kontrol edilmesi gereken durumlar
                //ad soyad 2 karakterde olmalı

                if (txtDrAd.Text.Trim().Length < 2) //Doktor adı ----> SU gibi iki harfli olabilir ama daha kısa bir isim olmayacağı için bu şekilde kabul ediyoruz
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz.");
                }

                if (txtDrSoyad.Text.Trim().Length < 2) //Doktor soyadı ----> AK gibi iki harfli olabilir ama daha kısa bir isim olmayacağı için bu şekilde kabul ediyoruz
                {
                    throw new Exception("Lütfen doktor adını düzgün giriniz.");
                }
                //tc kimlik numarası

                if (txtDrTc.Text.Trim().Length!=11)
                {
                    throw new Exception("TC Kimlik numarası 11 haneli olmalıdır!");
                }

                if (txtDrTc.Text.Any(x=> !char.IsDigit(x)))
                {
                    throw new Exception("TC Kimlik numarası rakamlardan oluşacak şekilde 11 haneli olmalıdır!");
                }

                //telefon

                


                Doktor yeniDoktor = new Doktor()
                {
                    DoktorAdi = txtDrAd.Text.Trim(),
                    DoktorSoyadi = txtDrSoyad.Text.Trim(),
                    TCNumarasi = txtDrTc.Text,
                    Email = txtDrEmail.Text.Trim(),
                    Telefon = maskedTextBoxDrTel.Text.Replace("-",""),
                    Brans = drBransi
                };
                //Veri tabanına ekleyelim.
                if (drManager.YeniDoktorEkle(yeniDoktor))
                {
                    MessageBox.Show($"{txtDrAd.Text.Trim()} {txtDrSoyad.Text.Trim()} sisteme yeni doktorumuz olarak eklenmiştir!");
                }
                //TEMİZLİK
                DrEkleSayfasiTemizle();
                DrGrideVerileriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("HATA : " + ex.Message);
            }
        }

        private void DrGrideVerileriGetir()
        {
            dataGridViewDoktor.DataSource =
                 drManager.TumAktifDoktorlariGetir();

        }

        private void DrEkleSayfasiTemizle()
        {
            txtDrAd.Clear();
            txtDrSoyad.Clear();
            txtDrTc.Clear();
            txtDrEmail.Clear();
            comboBoxDrBranslar.SelectedValue = 0;
            maskedTextBoxDrTel.Clear();
        }
    }
}

