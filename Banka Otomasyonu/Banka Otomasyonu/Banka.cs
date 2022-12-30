using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka_Otomasyonu
{
    public class Banka
    {
        public string BankaAdi { get; set; }

        public List<Musteri> Musteriler = new List<Musteri>();
        public int MusterininListedekiIndexi { get; set; }

        public Banka()
        {
            BankaAdi = "BakircayBank";
        }
        
        public void YeniMusteriEkle(Musteri musteri)
        {
            Musteriler.Add(musteri);
        }

        public int HesapKimeAit(int HesapNo)                    // Verilen Hesap Numarasının, Müşteriler Listesinde Kaçıncı Indexteki Kullanıcıya ait olduğunu Belirler
        {
            int MusteriIndexi = -1;

            foreach(Musteri musteri in Musteriler)
            {
                if(musteri.HesaplarIcindeIndexBelirle(HesapNo) != -1)   // -1 Dönüşü "musteri.Hesaplar listesinde bulunamadı" anlamına gelir
                {
                    return MusteriIndexi;
                }
            }
            return MusteriIndexi;   // Fonksiyondan -1 Dönüşü "Hesap Bankamız Kayıtlarında Bulunamadı" anlamına gelir
        }

        private bool SifreDogrula(string Sifre, int MusteriIndexi)
        {
            
                if(Musteriler[MusteriIndexi].Sifre == Sifre) 
                {
                   
                    return true; 
                }
            
            return false;
        }

        private bool MusteriNoDogrula(int MusteriNo)
        {
            int i = 0;

            foreach (Musteri musteri in Musteriler)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    MusterininListedekiIndexi = i;          //Musteri Indexi Burda Belirleniyor
                    return true;
                }
                i++;
            }
            return false;
        }
        public bool MusteriNoveSifreDogrula(int MusteriNo,string Sifre)
        {
          if(MusteriNoDogrula(MusteriNo) && SifreDogrula(Sifre,MusterininListedekiIndexi))
            {
                return true;
            }
            return false;
        }

    }
}
