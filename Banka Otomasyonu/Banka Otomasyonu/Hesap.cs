using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class Hesap
    {
        public int HesapNo { get; }
        public int Bakiye { get; set; }
        public string HesapTipi { get; set; }

        Random random = new Random();
        
        public Hesap()
        {
            HesapNo = random.Next(100, 200);
            Bakiye = 0;
            HesapTipi = "";
        }
    }
}
