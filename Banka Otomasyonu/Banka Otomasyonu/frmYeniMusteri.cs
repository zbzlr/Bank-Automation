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
    public partial class frmYeniMusteri : Form
    {
        private Banka banka;
        public frmYeniMusteri(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void checkBox_Bireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Bireysel.Checked)
            {
                checkBox_Ticari.Checked = false;
            }
        }

        private void checkBox_Ticari_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Ticari.Checked)
            {
                checkBox_Bireysel.Checked = false;
            }
        }

        public bool SifrelerUyusuyorMu(string ilkVeri , string ikinciVeri)
        {
            if(ilkVeri == ikinciVeri) { return true; }
            else { return false; }
        }

        private void btn_YeniKayitOlustur_Click(object sender, EventArgs e)
        {
            string MusteriTipi;

            if (SifrelerUyusuyorMu(txt_Sifre.Text, txt_TekrarSifre.Text) == false)
            {
                MessageBox.Show("Girdiğiniz Şifreler Aynı Değil.\nLütfen Tekrar Deneyin...");
                return;
            }

            if (checkBox_Bireysel.Checked == true)
            {
                MusteriTipi = "Bireysel";
            } else if (checkBox_Ticari.Checked == true)
            {
                MusteriTipi = "Ticari";
            } else
            {
                MessageBox.Show("Lütfen Ticari veya Bireysel Müşteri Seçeneklerinden Birini İşaretleyin");
                return;
            }

            
            Musteri musteri = new Musteri(txt_Isim.Text, txt_Soyisim.Text, MusteriTipi, txt_Sifre.Text);
            banka.YeniMusteriEkle(musteri);   
            MessageBox.Show("Kayıt Başarılı...\n\nMüşteri Numaranız: " + musteri.MusteriNo);

            Close();
        }
    }
}
