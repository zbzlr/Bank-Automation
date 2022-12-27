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
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_YeniMusteriyim_Click(object sender, EventArgs e)
        {
            frmYeniMusteri frmYeniMusteri = new frmYeniMusteri();
            frmYeniMusteri.Show();
        }
    }
}
