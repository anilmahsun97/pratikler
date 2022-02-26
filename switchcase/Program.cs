using System;

namespace switchcase // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            switch (month) // expression
            {
                case 1:
                    Console.WriteLine("Ocak ayindayiz");
                    break;
                case 2:
                    Console.WriteLine("Ocak ayindayiz");
                    break;
                case 3:
                    Console.WriteLine("Ocak ayindayiz");
                    break;
                case 4:
                    Console.WriteLine("Ocak ayindayiz");
                    break;
                default:
                Console.WriteLine("Yanlis ifade girdiniz !");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Ayindasiniz");
                    break;
                default:
                break;
            }
        }
    }
}