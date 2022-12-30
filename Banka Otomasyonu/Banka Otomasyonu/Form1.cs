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
    public partial class frm_login : Form
    {
        private Banka banka;

        public frm_login()
        {
            InitializeComponent();
            banka = new Banka();
        }

        private void btn_YeniMusteriyim_Click(object sender, EventArgs e)
        {
            frmYeniMusteri frmYeniMusteri = new frmYeniMusteri(banka);
            frmYeniMusteri.Show();
        }
        
        public void frm_login_Load(object sender, EventArgs e)
        {
            Musteri musteriAdmin = new Musteri("Ziya", "Bozlar", "Bireysel", "2727", 99);
            musteriAdmin.HesapEkle();
            musteriAdmin.Hesaplar[0].Bakiye = 300;
            banka.YeniMusteriEkle(musteriAdmin);
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (banka.MusteriNoveSifreDogrula(Convert.ToInt32(txt_MusteriNo.Text), txt_Sifre.Text))
            {
                frmAnaEkran anaEkran = new frmAnaEkran(banka);
                anaEkran.Show();
                txt_MusteriNo.Clear();
                txt_Sifre.Clear();
            }
            else
            {
                MessageBox.Show("Müşteri No veya Şifre Hatalı. Lütfen Tekrar Deneyin...");
                return;
            }
        }
    }
}
