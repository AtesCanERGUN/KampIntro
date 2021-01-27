using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.TcNo="1234567890";
            musteri1.Adi = "Ateş Can";
            musteri1.Soyadi = "Ergün";

            TuzelMusteri musteri2 = new TuzelMusteri {Id=2,MusteriNo="543211",SirketAdi="Yıldız Ticeret",VergiNo="12345678910" };

            Musteri musteri3 = new GercekMusteri();
            musteri3.Id = 3;
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
          
        }
    }
}
