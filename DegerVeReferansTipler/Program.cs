using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar[0] ? 999 
            //niye : 
            //int , decimal, floot, double, bool = değer tip
            //array, class, interface = referas tip
            //new demek bellekte yeni bir adres oluştur demek
            //diziler adres tutar. sayilar1=sayilar2 dediğimiz de 2nin adresini 1 e tanımlıyoruz.

        }
    }
}