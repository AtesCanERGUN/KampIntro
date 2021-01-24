using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirme kampı";
            string kurs2 = "programlama başlangıçı";
            string kurs3 = "java kursu";

            //array - diziler

            string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlama başlangıçı", "java kursu","paython","c++","c#" };

            for (int i = 0; i<kurslar.Length ; i++)
            {
                  Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            Console.WriteLine("ımam hatıpler kapatılsın");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu  - footer");
        }
    }
}
