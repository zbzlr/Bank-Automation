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
    public partial class frmIslemGecmisi : Form
    {
        private Banka banka;
        public frmIslemGecmisi(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void frmIslemGecmisi_Load(object sender, EventArgs e)
        {
            foreach (Hesap hesap in banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar)
            {
                comboBox_HesapNo.Items.Add(hesap.HesapNo);
            }

        }

        private void comboBox_HesapNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            listView_Havale.Items.Clear();
            listView_ParaCekYatir.Items.Clear();

            HesapGecmisiListele(TarihAraligiBelirle());

            txt_HesapBakiyesi.Text = Convert.ToString(banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapNo.SelectedIndex].Bakiye);
            
        }

        private void comboBox_Tarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView_Havale.Items.Clear();
            listView_ParaCekYatir.Items.Clear();

            HesapGecmisiListele(TarihAraligiBelirle());

            txt_HesapBakiyesi.Text = Convert.ToString(banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapNo.SelectedIndex].Bakiye);
        }

        private DateTime TarihAraligiBelirle()
        {
            switch (comboBox_Tarih.SelectedIndex)
            {
                case 1:
                    return DateTime.Today;
                case 2:
                    return DateTime.Today.AddDays(-7);
                case 3:
                    return DateTime.Today.AddDays(-30);
                default:
                    return DateTime.MinValue;
            }
        }

        private void HesapGecmisiListele(DateTime tarihAraligi)
        {
            foreach (IslemGecmisi islem in banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapNo.SelectedIndex].Islemler)  // Tabcontrol ilk tab için çalışır
            {

                    if (islem.IslemKategorisi.Contains("Havale") == true || islem.IslemTarihi < tarihAraligi)
                    {
                        continue;
                    }


                ListViewItem item = new ListViewItem(islem.IslemKategorisi);
                item.SubItems.Add(Convert.ToString(islem.IslemTutari));
                item.SubItems.Add(Convert.ToString(islem.IslemTarihi));
                listView_ParaCekYatir.Items.Add(item);
            }

            foreach (IslemGecmisi islem in banka.Musteriler[banka.MusterininListedekiIndexi].Hesaplar[comboBox_HesapNo.SelectedIndex].Islemler)  // Tabcontrol ikinci tab için çalışır
            {

                    if (islem.IslemKategorisi.Contains("Havale") == false || islem.IslemTarihi < tarihAraligi)
                    {
                        continue;
                    }

                string KarsiTarafinAdiSoyadi = "";

                    if (islem.HesapNo_KarsiTaraf != null)
                    {
                        int KarsiTarafinBankadakiIndexi = banka.HesapKimeAit(islem.HesapNo_KarsiTaraf);
                        KarsiTarafinAdiSoyadi = banka.Musteriler[KarsiTarafinBankadakiIndexi].MusteriAdi + " " + banka.Musteriler[KarsiTarafinBankadakiIndexi].MusteriSoyadi;
                    }

                ListViewItem item = new ListViewItem(islem.IslemKategorisi);
                item.SubItems.Add(Convert.ToString(islem.IslemTutari));
                item.SubItems.Add(Convert.ToString(islem.IslemTarihi));
                item.SubItems.Add(KarsiTarafinAdiSoyadi);
                item.SubItems.Add(islem.Aciklama);
                listView_Havale.Items.Add(item);

            }

        }
    }
}
