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
    public partial class frmHesaplariYonet : Form
    {
        private Banka banka;

        
        private void HesaplariListele(Musteri musteri)
        {
            listView_HesapBilgileri.Items.Clear();
            
            foreach(Hesap hesap in musteri.Hesaplar) //Müşterinin tüm hesaplarını döndürerek listview'a ekler

            {
                ListViewItem item = new ListViewItem(Convert.ToString(hesap.HesapNo));
                item.SubItems.Add(hesap.HesapTipi);
                item.SubItems.Add(Convert.ToString(hesap.Bakiye));
                listView_HesapBilgileri.Items.Add(item);
            }
            
        }
        public frmHesaplariYonet(Banka banka)   //Daha önce oluşturulan banka nesnesini diğer formlardan çeker.
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void btn_HesapOlustur_Click(object sender, EventArgs e)
        {
            banka.Musteriler[banka.MusterininListedekiIndexi].HesapEkle();
            HesaplariListele(banka.Musteriler[banka.MusterininListedekiIndexi]);

            MessageBox.Show("Hesabınız Başarıyla Oluşturuldu");
        }

        private void frmHesaplariYonet_Load(object sender, EventArgs e)
        {
            HesaplariListele(banka.Musteriler[banka.MusterininListedekiIndexi]);
        }

        private void btn_HesapSil_Click(object sender, EventArgs e)
        {

            if (banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar.Count == 0)  // Eğer Müşterinin Hesabı Yoksa Çalışır
                {
                    MessageBox.Show("Bankamızda Hesabınız Bulunmamaktadır...");
                    return;
                }

            if (listView_HesapBilgileri.SelectedIndices.Count == 0)    // Eğer Listview'da Hiçbir İtem Seçilmediyse Çalışır
                {
                    MessageBox.Show("Kapatmak İstediğiniz Hesabı Lütfen Yukarıdaki Tablodan Seçiniz...");
                    return;
                }

            DialogResult result = MessageBox.Show("Seçilen Hesabı Silmek Istediğinize Emin Misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes && (banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[listView_HesapBilgileri.SelectedItems[0].Index].Bakiye == 0)) // MessageBox Yes ve Hesap Bakiyesi 0 ise Çalışır
                {
                    banka.Musteriler[banka.MusterininListedekiIndexi].HesapSil(listView_HesapBilgileri.SelectedItems[0].Index);
                    MessageBox.Show("Hesap Başarıyla Silindi.");
                    HesaplariListele(banka.Musteriler[banka.MusterininListedekiIndexi]);
                } 

        else if(result == DialogResult.Yes && (banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[listView_HesapBilgileri.SelectedItems[0].Index].Bakiye != 0))   // MessageBox Yes ve Hesap Bakiyesi 0 DEĞİL ise Çalışır
            {
                DialogResult result2 = MessageBox.Show("Hesap Bakiyesi 0 olmadan Hesap Kapatma İşlemi Yapamamaktayız. Hesabınızdaki Parayı Çekmek İster Misiniz?", "İşlem Başarısız!", MessageBoxButtons.YesNo);
                
                if(result2 == DialogResult.Yes)
                    {
                        frmParaCekYatir paraCekYatir = new frmParaCekYatir(banka);   //Para Çek/Yatır Ekranına Yönlendirir
                        paraCekYatir.Show();
                    }
            }
        }

        private void btn_AnaSayfayaDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
