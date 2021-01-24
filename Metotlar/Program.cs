using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elması";
                
            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbarkır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Zeytin";
            urun3.Fiyati = 45;
            urun3.Aciklama = "Trilye Zeytıni";



            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati +" TL");
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("---------------------metotlar----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            //ekle 2 komutu kullanışsızz bir alternatiftir.

            sepetManager.Ekle2("Armut", " Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", " Yeşil Elma", 15, 100);
            sepetManager.Ekle2("Karpuz", " Diyarbakır Karpuzu", 20, 8);

        }
    }
}


