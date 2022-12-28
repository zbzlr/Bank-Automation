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
            Musteri musteri = new Musteri("Ziya", "Bozlar", "Bireysel", "2727", 99);
            Musteriler.Add(musteri);
        }
        
        public void YeniMusteriEkle(Musteri musteri)
        {
            Musteriler.Add(musteri);
        }

        private bool SifreDogrula(string Sifre)
        {
            int i = 0;

            foreach(Musteri musteri in Musteriler)
            {
                if(musteri.Sifre == Sifre) 
                {
                    MusterininListedekiIndexi = i;
                    return true; 
                }
            }
            return false;
        }

        private bool MusteriNoDogrula(int MusteriNo)
        {
            foreach (Musteri musteri in Musteriler)
            {
                if (musteri.MusteriNo == MusteriNo)
                {
                    return true;
                }
            }
            return false;
        }
        public bool MusteriNoveSifreDogrula(int MusteriNo,string Sifre)
        {
          if(MusteriNoDogrula(MusteriNo) && SifreDogrula(Sifre))
            {
                return true;
            }
            return false;
        }

    }
}
