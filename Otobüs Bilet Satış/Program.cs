using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BiletSatışProgramı
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Otobüs Bileti Satış Programı **********");
            İstanbulOtobüs o = new İstanbulOtobüs("İstanbul", 40);
            AnkaraOtobüs ao = new AnkaraOtobüs("Ankara", 40);
            while (true)
            {
                Console.WriteLine("\n1. İstanbul Bilet Sat\n2. Ankara Bilet Sat \n3. Bilet İptal\n4. Bakiye Öğren");
                Console.Write("Seçiminizi yapın (1-4): ");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Write("Satılacak bilet sayısını girin: ");
                    int biletSayisi;
                    while (!int.TryParse(Console.ReadLine(), out biletSayisi) || biletSayisi <= 0)
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir tamsayı girin.");
                        Console.Write("Satılacak bilet sayısını girin: ");
                    }

                    Console.Write("Bilet türünü girin (indirimsiz: 1, indirimli: 0): ");
                    int biletTuru;
                    while (!int.TryParse(Console.ReadLine(), out biletTuru) || (biletTuru != 0 && biletTuru != 1))
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen 0 veya 1 değeri girin.");
                        Console.Write("Bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                    }

                    bool indirimli = (biletTuru == 1);
                    o.BiletSatist(biletSayisi, indirimli);



                }
                else if (secim == "2")
                {
                    Console.Write("Satılacak bilet sayısını girin: ");
                    int biletSayisi;
                    while (!int.TryParse(Console.ReadLine(), out biletSayisi) || biletSayisi <= 0)
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir tamsayı girin.");
                        Console.Write("Satılacak bilet sayısını girin: ");
                    }

                    Console.Write("Bilet türünü girin (indirimsiz: 1, indirimli: 0): ");
                    int biletTuru;
                    while (!int.TryParse(Console.ReadLine(), out biletTuru) || (biletTuru != 0 && biletTuru != 1))
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen 0 veya 1 değeri girin.");
                        Console.Write("Bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                    }

                    bool indirimli = (biletTuru == 1);
                    ao.BiletSatAnk(biletSayisi, indirimli);


                }
                else if (secim == "3")
                {
                    Console.WriteLine("Hangi Sefer için iptal işlemi yapılacak ? : \n1İstanbul \n2Ankara");
                    string secim1 = Console.ReadLine();
                    if (secim1 == "1")

                    {
                        Console.Write("İptal edilecek bilet sayısını girin: ");
                        int biletSayisi;
                        while (!int.TryParse(Console.ReadLine(), out biletSayisi) || biletSayisi <= 0)
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir tamsayı girin.");
                            Console.Write("İptal edilecek bilet sayısını girin: ");
                        }

                        Console.Write("İptal edilecek bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                        int biletTuru;
                        while (!int.TryParse(Console.ReadLine(), out biletTuru) || (biletTuru != 0 && biletTuru != 1))
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen 0 veya 1 değeri girin.");
                            Console.Write("İptal edilecek bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                        }

                        bool indirimli = (biletTuru == 1);

                        o.BiletIptal(biletSayisi, indirimli);

                    }
                    else
                    {
                        Console.Write("İptal edilecek bilet sayısını girin: ");
                        int biletSayisi;
                        while (!int.TryParse(Console.ReadLine(), out biletSayisi) || biletSayisi <= 0)
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen pozitif bir tamsayı girin.");
                            Console.Write("İptal edilecek bilet sayısını girin: ");
                        }

                        Console.Write("İptal edilecek bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                        int biletTuru;
                        while (!int.TryParse(Console.ReadLine(), out biletTuru) || (biletTuru != 0 && biletTuru != 1))
                        {
                            Console.WriteLine("Geçersiz giriş! Lütfen 0 veya 1 değeri girin.");
                            Console.Write("İptal edilecek bilet türünü girin (indirimli: 1, indirimsiz: 0): ");
                        }

                        bool indirimli = (biletTuru == 1);

                        ao.BiletIptal(biletSayisi, indirimli);
                    }
                }
                else if (secim == "4")
                {
                    double Ciro = ao.CiroOgren();
                    double Ciro1 = o.CiroOgren();
                    Console.WriteLine("Sinema salonunun toplam cirosu: {0}", ao.CiroOgren() + o.CiroOgren());
                }

            }

            
        }
    }
}
            











           
        
    














