using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatışProgramı
{
    public class AnkaraOtobüs
    {
        public double Ciro;
        public string AnkaraSeferi;
        public int Toplamkoltuksayısı = 40;
        public int Boskoltuksayısı;
        public int Dolukoltuksayısı;
        public double Tam = 200;
        public double İndirimli = 180;

        public AnkaraOtobüs(string İstanbulSeferi, int KoltukKapasitesi)
        {
            Boskoltuksayısı = KoltukKapasitesi;
            Dolukoltuksayısı = 0;
            Ciro = 0;
        }

        public void BiletSatAnk(int biletSayisi, bool indirimli)
        {
            if (Boskoltuksayısı >= biletSayisi)
            {
                double biletFiyati = indirimli ? Tam : İndirimli;
                Ciro += biletFiyati * biletSayisi;
                Boskoltuksayısı -= biletSayisi;
                Dolukoltuksayısı += biletSayisi;
                Console.WriteLine("{0} adet {1} bilet satıldı.", biletSayisi, indirimli ? "indirimsiz" : "indirimli");
                Console.WriteLine("Toplam ciro: {0}", Ciro);
            }
            else
            {
                Console.WriteLine("Tüm Koltuklar dolu! Yeterli boş koltuk bulunmamaktadır.");
            }
        }

        public int BosKoltukOgrenAnk()
        {
            return Boskoltuksayısı;
        }

        public double CiroOgren()
        {
            return Ciro;
        }

        public void BiletIptal(int biletSayisi, bool indirimli)
        {
            if (Dolukoltuksayısı >= biletSayisi)
            {
                double biletFiyati = indirimli ? Tam : İndirimli;
                Ciro -= biletFiyati * biletSayisi;
                Boskoltuksayısı += biletSayisi;
                Dolukoltuksayısı -= biletSayisi;
                Console.WriteLine("{0} adet {1} bilet iptal edildi.", biletSayisi, indirimli ? "indirimli" : "indirimsiz");
                Console.WriteLine("Toplam ciro: {0}", Ciro);
            }
            else
            {
                Console.WriteLine("İptal edilecek kadar dolu koltuk bulunmamaktadır.");
            }
        }
    }
}


