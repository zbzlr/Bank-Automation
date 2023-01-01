using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class Hesap
    {
        public int HesapNo { get; set; }
        public double Bakiye { get; set; }
        public string HesapTipi { get; set; }

        public List<IslemGecmisi> Islemler = new List<IslemGecmisi>();

        Random random = new Random();
        
        public Hesap()
        {
            HesapNo = random.Next(100, 200);
            Bakiye = 0;
        }

        public void IslemEkle(double IslemTutari, string IslemKategorisi, DateTime IslemTarihi, int HesapNo)     // Para Çekme ve Yatırma İşlemleri İçin Kullanılır
        {
            IslemGecmisi ıslemBilgisi = new IslemGecmisi(IslemTutari, IslemKategorisi, IslemTarihi, HesapNo);
            Islemler.Add(ıslemBilgisi);
        }
        public void IslemEkle(double IslemTutari, string IslemKategorisi, DateTime IslemTarihi, int HesapNo, int HesapNo_KarsiTaraf, string Aciklama)     // Havale İşlemleri İçin Kullanılır
        {
            IslemGecmisi ıslemBilgisi = new IslemGecmisi(IslemTutari, IslemKategorisi, IslemTarihi, HesapNo,HesapNo_KarsiTaraf,Aciklama);
            Islemler.Add(ıslemBilgisi);
        }
    }
}
