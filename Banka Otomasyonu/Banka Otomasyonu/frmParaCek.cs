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
    public partial class frmParaCekYatir : Form
    {
        private Banka banka;
        public frmParaCekYatir(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void frmParaCekYatir_Load(object sender, EventArgs e)
        {
            foreach(Hesap hesap in banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar)
            {
                comboBox_HesapSecimi.Items.Add(hesap.HesapNo);
            }
        }

        private void btn_ParaYatir_Click(object sender, EventArgs e)
        {
            int HesapNo = Convert.ToInt32(comboBox_HesapSecimi.SelectedItem);
            double YatirilacakTutar = Convert.ToDouble(txt_IslemTutari.Text);
            banka.Musteriler[banka.MusterininListedekiIndexi].ParaYatir(HesapNo, YatirilacakTutar);
            
                MessageBox.Show("İşlem Başarılı");
                txt_IslemTutari.Clear();
            
        }

        private void btn_ParaCek_Click(object sender, EventArgs e)
        {
            int HesapNo = Convert.ToInt32(comboBox_HesapSecimi.SelectedItem);
            double IslemTutari = Convert.ToDouble(txt_IslemTutari.Text);
            int ParaCekIslemSonucu; // Para Çekme İşleminin Hangi Yoldan Yapıldığını Anlamamıza Yardımcı Olur

            ParaCekIslemSonucu = banka.Musteriler[banka.MusterininListedekiIndexi].ParaCek(HesapNo, IslemTutari);


            if (ParaCekIslemSonucu == 0)    // Hesaplardaki Toplam Para Çekilmek İstenen Tutarı Karşılamıyor
            {
                MessageBox.Show("Hesabınızda Yeterli Para Bulunmamaktadır.\n" + "Hesap Bakiyeniz: " + (banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapSecimi.SelectedIndex].Bakiye) + "TL");
                txt_IslemTutari.Clear();
                return;
            }

            if(ParaCekIslemSonucu == 1)    // Seçilen Hesapta Yeterli Para Var Kullanıcı İşlemi Onayladı
            {
                MessageBox.Show("İşlem Başarıyla Gerçekleştirildi.\n" + "Güncel Hesap Bakiyeniz:" + banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapSecimi.SelectedIndex].Bakiye + "TL");
                txt_IslemTutari.Clear();
                return;
            }

            if(ParaCekIslemSonucu == 2)    // Seçilen Hesapta Yeterli Para Yoktu ve Kullanıcı Diğer Hesaplardan Tamamlamak İstemedi
            {
                MessageBox.Show("İşlem İptal Edildi.");
                txt_IslemTutari.Clear();
                return;
            }

            if(ParaCekIslemSonucu == 3)    // Seçilen Hesapta Yeterli Para Yoktu. Eksik Kalan Tutar Diğer Hesaplardan Tamamlandı
            {
                MessageBox.Show("İşleminiz Başarıyla Gerçekleştirildi. Hesaplarınızın Güncel Bakiyesini Hesaplarım Sekmesinden Görüntüleyebilirsiniz");
                txt_IslemTutari.Clear();
                return;
            }

            if(ParaCekIslemSonucu == 4)    // Hesapta Yeterli Para Vardı. Musteri İslemden Vazgecti
            {
                MessageBox.Show("İşlem İptal Edildi.");
                txt_IslemTutari.Clear();
                return;
            }
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
