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
    public partial class frmAnaEkran : Form
    {
        private Banka banka;
        public frmAnaEkran(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void paraCekYatirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaCekYatir paraCekYatir = new frmParaCekYatir(banka);
            paraCekYatir.Show();
        }

        private void HesaplariYonetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesaplariYonet hesaplariYonet = new frmHesaplariYonet(banka);
            hesaplariYonet.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Oturumunuzu Kapatmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void havaleYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavaleYap havaleYap = new frmHavaleYap(banka);
            havaleYap.Show();
        }
    }
}
