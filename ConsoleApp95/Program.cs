using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilensayibolme
{
    class Program
    {
        static void Main(string[] args)
        {
            int bolunen, bolen, bolum;

            Console.WriteLine("Lütfen Bölünen sayıyı giriniz");
            bolunen = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Bölen sayıyı giriniz");
            bolen = Int32.Parse(Console.ReadLine());

            bolum = bolunen / bolen;

            Console.WriteLine("Çıkan bölüm: {0}", bolum);
            Console.ReadLine();


        }
    }
}