using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ateş", "Batu", "Semih Abi", "Pelkas" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Özil";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[1]); 
            //yeni tanımda 5 elemanın sadece 4. tanımlandı üsttekiyle alaksa sıfır...


            List<string> isimler2 = new List<string>() {"Ateş", "Batu","Semıh Abi", "Pelkas" }; //list komutu en üstte eklendı ( soldaki ampulden)
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add( "Özil");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
