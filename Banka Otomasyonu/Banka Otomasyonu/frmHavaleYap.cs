using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    
    public partial class frmHavaleYap : Form
    {
        private Banka banka;
        public frmHavaleYap(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void frmHavaleYap_Load(object sender, EventArgs e)
        {
            foreach (Hesap hesap in banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar)
            {
                comboBox_HavaleYapanHesapNo.Items.Add(hesap.HesapNo);
            }
        }

        private void btn_HavaleYap_Click(object sender, EventArgs e)
        {

            if (txt_HavaleTutari.Text == null || txt_HavaleYapilacakHesap.Text == null || richTextBox_Aciklama.Text == null || comboBox_HavaleYapanHesapNo.SelectedItem == null) //Gerekli alanların boş bırakılmasını engeller
            {
                MessageBox.Show("Lütfen Tüm İlgili Alanları Doldurunuz...");
                return;
            }

            int HavaleYapilacakHesapNo = Convert.ToInt32(txt_HavaleYapilacakHesap.Text);
            double IslemTutari = Convert.ToDouble(txt_HavaleTutari.Text);
            double SanalIslemTutari = IslemTutari;
            int HavaleYapanHesapNo = Convert.ToInt32(comboBox_HavaleYapanHesapNo.SelectedItem);
            string Aciklama = richTextBox_Aciklama.Text;

            int HavaleYapIslemSonucu = banka.Musteriler[banka.MusterininListedekiIndexi].HavaleYap(HavaleYapilacakHesapNo, IslemTutari, HavaleYapanHesapNo,Aciklama, banka); // Havale Burda Yapılır

                if (HavaleYapIslemSonucu == -1)     //Hesap Bulunamadı
                {
                    MessageBox.Show("Havale Yapmak İstediğiniz Hesap Numarası Bankamız Kayıtlarında Bulunmamaktadır...", "Islem Basarısız.");
                    txt_HavaleYapilacakHesap.Clear();
                    return;

                }

                    DialogResult result = MessageBox.Show("Havale Yapılacak Musteri:" + banka.Musteriler[banka.HesapKimeAit(HavaleYapilacakHesapNo)].MusteriAdi + " " 
                        + banka.Musteriler[banka.HesapKimeAit(HavaleYapilacakHesapNo)].MusteriSoyadi
                        + "\nGönderilecek Tutar: " + txt_HavaleTutari.Text + " TL"
                        + "\nHesabınızdan Kesilecek Tutar: " + banka.Musteriler[banka.MusterininListedekiIndexi].Havale_HesaptanKesilecekTutariBelirle(SanalIslemTutari).ToString() 
                        + "\n Açıklama: " + richTextBox_Aciklama.Text 
                        + "\n\nIsleme Devam Etmek İstiyor Musunuz?", "Dikkat!", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                
                        if (HavaleYapIslemSonucu == 0)  // Yetersiz Bakiye
                            {
                                DialogResult result2 = MessageBox.Show("Hesap Bakiyeniz Bu İşlem Tutarı İçin Müsait Değil. Hesap Bakiyenizi Görmek İster Misiniz?", "Islem Basarısız.",MessageBoxButtons.YesNo);

                                if (result2 == DialogResult.Yes)
                                {
                                    MessageBox.Show("Hesap No: " + comboBox_HavaleYapanHesapNo.SelectedItem.ToString() + "\nBakiye: " + Convert.ToString(banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HavaleYapanHesapNo.SelectedIndex].Bakiye));
                                    return;
                                }
                            }

                        if(HavaleYapIslemSonucu == 1)   // İşlem Başarılı
                            {
                                MessageBox.Show("Guncel Hesap Bakiyeniz: " + Convert.ToString(banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HavaleYapanHesapNo.SelectedIndex].Bakiye) + "TL","Islem Basarili");
                                return;
                            }
                } 
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
