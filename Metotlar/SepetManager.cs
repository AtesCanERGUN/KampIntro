using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {    //komut ekleme publıc void İSİM
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi :   " +  urun.Adi) ;
        }
        //alttakıni tercih edilmeyen alternatif X
        public void Ekle2(string urunAdi, string aciklama , double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler , Sepete Eklendi :   " + urunAdi);
        }
    }
}
