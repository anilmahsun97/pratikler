using System;

namespace tip_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion (bilincsiz donusum)
            Console.WriteLine(" *** implicit conversion***");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d :" + d);
            string e = "Anil";
            char f ='k';
            object g = a+e+f;
            Console.WriteLine("g :" + g);
 


            //explicit conversion (bilincli donusum)
            Console.WriteLine(" *** explicit conversion***");
            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);
            // *** ToString Methodu ***
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);
            // System.Conver
            string s1 = "10",s2 = "20";
            int sayi1,sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + toplam);

            //Parse Methodu : String ifadelere donusturmek icin kullanilir.

            ParseMethod();
        }
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;
            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1: " + rakam1);
            Console.WriteLine("double1: " + double1);
        }
    }
}