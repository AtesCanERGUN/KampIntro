using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yaş = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOrani = 68;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.IzlenmeOrani = 64;


            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.Egitmen = "berkay";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            //foreach listeleme komutu (içine gösterilecek bilgiler cw tab tab kısa console write)



           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }


    }
}
