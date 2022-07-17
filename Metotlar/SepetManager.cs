using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        // syntax yazım şekilleri
        // ekle yanız başına bir anlamı yok neyi ekleyeceğimiz parametre demek
        // (parametrenin tipi - urun)
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat,int stokAdedi) 
        {
            Console.WriteLine("Tebrikler.Sepete eklendi : " + urunAdi);
        }
    }
}
