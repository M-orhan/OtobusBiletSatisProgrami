using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOBÜS_ÖDEV
{
    public class İstanbulOtobüs
    {
        public double Ciro1;
        public string İstanbulSeferi;
        public int Toplamkoltuksayısı=40;
        public int Boskoltuksayısı;
        public int Dolukoltuksayısı;
        public double Tam = 200;
        public double İndirimli = 180;

        public İstanbulOtobüs(string İstanbulSeferi,int KoltukKapasitesi)
        {
            Boskoltuksayısı = KoltukKapasitesi;
            Dolukoltuksayısı = 0;
            Ciro1 = 0;
        }
       
        public void BiletSatist(int biletSayisi, bool indirimli)
        {
            if (Boskoltuksayısı >= biletSayisi)
            {
                double biletFiyati = indirimli ? Tam : İndirimli;
                Ciro1 += biletFiyati * biletSayisi;
                Boskoltuksayısı -= biletSayisi;
                Dolukoltuksayısı += biletSayisi;
                Console.WriteLine("{0} adet {1} bilet satıldı.", biletSayisi, indirimli ? "indirimsiz" : "indirimli");
                Console.WriteLine("Toplam ciro: {0}", Ciro1);
            }
            else
            {
                Console.WriteLine("Tüm Koltuklar dolu! Yeterli boş koltuk bulunmamaktadır.");
            }
        }

        public int BosKoltukOgren()
        {
            return Boskoltuksayısı;
        }

        public double CiroOgren()
        {
            return Ciro1;
        }

        public void BiletIptal(int biletSayisi, bool indirimli)
        {
            if (Dolukoltuksayısı >= biletSayisi)
            {
                double biletFiyati = indirimli ? Tam : İndirimli;
                Ciro1 -= biletFiyati * biletSayisi;
                Boskoltuksayısı += biletSayisi;
                Dolukoltuksayısı -= biletSayisi;
                Console.WriteLine("{0} adet {1} bilet iptal edildi.", biletSayisi, indirimli ? "indirimli" : "indirimsiz");
                Console.WriteLine("Toplam ciro: {0}", Ciro1);
            }
            else
            {
                Console.WriteLine("İptal edilecek kadar dolu koltuk bulunmamaktadır.");
            }
        }
    }
}

