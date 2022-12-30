using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banka_Otomasyonu
{
    public class Musteri
    {
       
        public int MusteriNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriTipi { get; set; }
        public string Sifre { get; set; }

        public List<Hesap> Hesaplar = new List<Hesap>();
        public Musteri(string Isim, string Soyisim, string musteriTipi, string sifre)
        {
            MusteriNoAta();
            MusteriAdi = Isim;
            MusteriSoyadi = Soyisim;
            MusteriTipi = musteriTipi;
            Sifre = sifre;
        }

        public Musteri(string Isim, string Soyisim, string musteriTipi, string sifre,int MusteriNo)
        {
            this.MusteriNo = MusteriNo;
            MusteriAdi = Isim;
            MusteriSoyadi = Soyisim;
            MusteriTipi = musteriTipi;
            Sifre = sifre;
        }

        public void MusteriNoAta()
        {
            Random random = new Random();
            MusteriNo = random.Next(200, 1000);
        }

        public void  HesapEkle()
        {
            Hesap hesap = new Hesap();
            hesap.HesapTipi = MusteriTipi;
            Hesaplar.Add(hesap);
        }

        public void HesapSil(int HesapIndexi)
        {
            Hesaplar.Remove(Hesaplar[HesapIndexi]);
        }

        public int HavaleYap(int HavaleYapilacakHesapNo , double IslemTutari ,int HavaleYapanHesapNo, Banka banka)
        {
            
            int HavaleYapanIndex = HesaplarIcindeIndexBelirle(HavaleYapanHesapNo);
            if(HesapHavaleIcinMusaitMi(IslemTutari, HavaleYapanIndex) == false)
            {
                return 0;   // Hesap Bakiyesi İşlem İçin Yetersiz
            }

            int MusterininBankadakiIndexi = banka.HesapKimeAit(HavaleYapilacakHesapNo);
            if (MusterininBankadakiIndexi == -1)
            {
                return -1;  // Havale Yapılacak Hesap Bankada Bulunamadı
            }

            int HavaleYapilacakIndex = banka.Musteriler[MusterininBankadakiIndexi].HesaplarIcindeIndexBelirle(HavaleYapilacakHesapNo);

            Hesaplar[HavaleYapanIndex].Bakiye -= Havale_HesaptanKesilecekTutariBelirle(IslemTutari);    // IslemTutari Gerekiliyse Komisyon Ücretiyle Birlikte Hesaptan Düşüyor

            banka.Musteriler[MusterininBankadakiIndexi].Hesaplar[HavaleYapilacakIndex].Bakiye += IslemTutari;   // Islem Tutari Katrsi Tarafın Hesabına Aktarılıyor

            return 1; // Islem Basarili

        }

        public double Havale_HesaptanKesilecekTutariBelirle(double IslemTutari)  // Ticari Musteriler Komisyonsuz Havale Yapabilir. Bireysel Musteriler Islem Tutarinin %2'si kadar komisyon öderler
        {
            double HesaptanKesilecekTutar = IslemTutari;

            if (MusteriTipi == "Bireysel")
            {
                HesaptanKesilecekTutar = IslemTutari + (IslemTutari * 0.02);
            }
            return HesaptanKesilecekTutar;
        }

        private bool HesapHavaleIcinMusaitMi(double IslemTutari,int HesapIndexi)       
        {
            double HesaptanKesilecekTutar = Havale_HesaptanKesilecekTutariBelirle(IslemTutari);

            if(Hesaplar[HesapIndexi].Bakiye >= HesaptanKesilecekTutar)
            {
                return true;
            }
            return false;
        }

        public int HesaplarIcindeIndexBelirle(int HesapNo)
        {
            int index = 0;
                foreach (Hesap hesap in Hesaplar)
                    {

                        if (HesapNo == hesap.HesapNo)
                            {
                                return index;
                            }

                        index++;
                    }
            return -1;      // -1 dönerse HesapNo Hesaplar listesinde bulunamadı anlamına geliyor.
        }

        private bool HesaptaYeterliParaVarMi(int HesapIndexi, double IslemTutari)
        {
            if(Hesaplar[HesapIndexi].Bakiye >= IslemTutari)
            {
                return true;
            }
            return false;
        }

        private double ToplamBakiye()          // Müşterinin Tüm Hesaplarındaki Bakiyeleri Toplar
        {
            double ToplamBakiye = 0;
            foreach (Hesap hesap in Hesaplar)
            {
                ToplamBakiye += hesap.Bakiye;
            }
            return ToplamBakiye;
        }

        private bool HesaplarToplamiTutariKarsiliyorMu(double CekilmekIstenenTutar)     // Hesaplar Toplamında Çekilmek İstenen Tutarın Olup Olmadığını Kontrol Eder
        {
            if(ToplamBakiye() >= CekilmekIstenenTutar)
            {
                return true;
            }
            return false;
        }

        public int ParaCek(int HesapNo , double CekilecekTutar)
        {
            int HesapIndexi = HesaplarIcindeIndexBelirle(HesapNo);

            if(HesaplarToplamiTutariKarsiliyorMu(CekilecekTutar) == false)
            {
                return 0; // Hesapların Toplamı Çekilmek İstenen Tutarı Karşılamıyor. İşlem Başarısız
            }
            
            if(HesaptaYeterliParaVarMi(HesapIndexi,CekilecekTutar) == true)
            {
                DialogResult result = MessageBox.Show("Çekilecek Tutar:" + Convert.ToString(CekilecekTutar) + "TL" + "\nİşlem Onayınız Sonrasında Gerçekleştirilecektir.", "DİKKAT!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Hesaplar[HesapIndexi].Bakiye -= CekilecekTutar;
                    return 1;    // Seçilen Hesapta Yeterli Para Var İşlem Başarılı   
                }
                return 4;  // İşlem Kullanıcı Tarafından İptal Edildi
                
            }
                else        // Seçilen Hesapta Yeterli Para Yok ama Hesaplar Toplamında var
                {       
                    DialogResult result = MessageBox.Show("Güncel Hesap Bakiyeniz:" + Hesaplar[HesapIndexi].Bakiye + "TL"+ "\nHesap Bakiyeniz Yeterli Değil. Eksik Tutarı Diğer Hesaplarınızdan Tamamlamak İster Misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
                
                        if (result == DialogResult.No)
                        {
                            return 2;   // Musteri Eksik Tutarı Diğer Hesaplarından Tamamlamak İstemedi. İşlem İptal
                        } 

                        else if(result == DialogResult.Yes)
                        {
                            EksikTutariDigerHesaplardanTamamla(HesapIndexi, CekilecekTutar);
                            return 3;   // Musteri Eksik Tutarı Diğer Hesaplarından Tamamlamak İstedi. İşlem Başarılı
                        }
                }

                return -1;  // Buraya Düşmemesi Gerekir. Düşerse Sorun Var Demektir.
        }

        private void EksikTutariDigerHesaplardanTamamla(int SecilenHesabinIndexi , double CekilecekTutar)
        {
            CekilecekTutar -= Hesaplar[SecilenHesabinIndexi].Bakiye;    // Cekilecek Tutardan Seçili Hesabın Bakiyesini Çıkartır
            Hesaplar[SecilenHesabinIndexi].Bakiye = 0;                 // Seçili Hesabın Bakiyesini 0'lar. Yani Seçili Hesaptaki paranın tamamını çeker

            int EnCokParaOlanHesapIndexi = EnCokParaOlanHesabiBelirle();

            while (CekilecekTutar != 0)     
            {
                if(Hesaplar[EnCokParaOlanHesapIndexi].Bakiye >= CekilecekTutar)     // En Çok Para Olan Hesaptaki Bakiye Yeterliyse Hepsini Ordan Çeker
                {
                    Hesaplar[EnCokParaOlanHesapIndexi].Bakiye -= CekilecekTutar;
                    break;
                } 

                else
                {
                    CekilecekTutar -= Hesaplar[EnCokParaOlanHesapIndexi].Bakiye;         // Cekilecek Tutardan Seçili Hesabın Bakiyesini Çıkartır
                    Hesaplar[EnCokParaOlanHesapIndexi].Bakiye = 0;                      // Hesabın Bakiyesini 0'lar
                    EnCokParaOlanHesapIndexi = EnCokParaOlanHesabiBelirle();           // Para Çekildikten Sonra En Çok Para Olan Hesabı Yeniden Belirler
                }
            }  
        }

        private int EnCokParaOlanHesabiBelirle()    
        {                                                                   
            double EnYuksekButceDegeri = 0;
            int index = 0;
            short i = 0;
            foreach(Hesap hesap in Hesaplar)
            {
                
                if(hesap.Bakiye > EnYuksekButceDegeri)
                {
                    
                        EnYuksekButceDegeri = hesap.Bakiye;
                        index = i;
                }
                i++;
            }
            return index;
        }
        public void ParaYatir(int HesapNo, double YatirilacakTutar)
        {
            int index = HesaplarIcindeIndexBelirle(HesapNo);

            Hesaplar[index].Bakiye += YatirilacakTutar;
        }

        
       


    }
}
