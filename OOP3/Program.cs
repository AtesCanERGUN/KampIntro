using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
           // ıhtiyacKrediManager.Hesapla();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();
            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();


            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();    //21-22-23 satır sonları new ekleme alternatifidir.
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new DataBaseLoggerService());
            basvuruManager.BasvuruYap(konutKrediManager, new FileLoggerService());
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new DataBaseLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,ihtiyacKrediManager,tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
