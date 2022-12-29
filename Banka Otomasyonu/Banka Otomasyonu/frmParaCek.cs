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
            int YatirilacakTutar = Convert.ToInt32(txt_IslemTutari.Text);
            banka.Musteriler[banka.MusterininListedekiIndexi].ParaYatir(HesapNo, YatirilacakTutar);
            
                MessageBox.Show("İşlem Başarılı");
                txt_IslemTutari.Clear();
            
        }
    }
}
