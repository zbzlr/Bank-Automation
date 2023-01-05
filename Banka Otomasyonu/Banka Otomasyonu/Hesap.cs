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
        
        public Hesap(Banka banka)
        {
            HesapNo = random.Next(100, 200);
            Bakiye = 0;

                while (banka.HesapKimeAit(HesapNo) != -1)  //Eğer HesapNo Banka Kayıtlarında Bulunmuyorsa -1 Dönüşü Yapar
                {
                    HesapNo = random.Next(200, 1000);     // Bu sayede farklı musterilere aynı müşteri no atanmasını engeller
                }

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
