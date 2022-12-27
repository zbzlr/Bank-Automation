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

        public void MusteriEkle(Musteri yeniMusteri)
        {
            Musteriler.Add(yeniMusteri);
        }

    }
}
