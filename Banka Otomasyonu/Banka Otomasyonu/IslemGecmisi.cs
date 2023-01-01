using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class IslemGecmisi
    {
        public double IslemTutari { get; set; }
        public string IslemKategorisi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public int HesapNo { get; set; }
        public int HesapNo_KarsiTaraf { get; set; }
        public string Aciklama { get; set; }

        public IslemGecmisi(double IslemTutari, string IslemKategorisi, DateTime IslemTarihi, int HesapNo)     // Para Çekme ve Yatırma İşlemleri İçin Kullanılır
        {
            this.IslemTutari = IslemTutari;
            this.IslemKategorisi = IslemKategorisi;
            this.IslemTarihi = IslemTarihi;
            this.HesapNo = HesapNo;
        }
        public IslemGecmisi(double IslemTutari, string IslemKategorisi, DateTime IslemTarihi, int HesapNo, int HesapNo_KarsiTaraf, string Aciklama)    // Havale İşlemleri İçin Kullanılır
        {
            this.IslemTutari = IslemTutari;
            this.IslemKategorisi = IslemKategorisi;
            this.IslemTarihi = IslemTarihi;
            this.HesapNo = HesapNo;
            this.HesapNo_KarsiTaraf = HesapNo_KarsiTaraf;
            this.Aciklama = Aciklama;
        }

    }
}
