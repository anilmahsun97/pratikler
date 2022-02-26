using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenler
{
    class Program
    {
        private static bool Monday;

        static void Main(string[]args)
        {
            //ValueTypes
            int number1 = 2147483647;
            long number2 = 2147483648;// sınırları 19 karakterden olusuyor longun.
            short number3 = 32767;
            byte number4 = 255;//0 ile 255 arasinda
            bool condition = true;// true veya false
            char character = 'a';
            string city = "Denizli";
            double number5 = 93.2;
            decimal number6 = 93.2m;
            var number7 = 93;
            number7 = 'A';
            //number7 = "A";
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(condition);
            Console.WriteLine(character);
            Console.WriteLine(city);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(Monday);
            Console.ReadLine();        
        }
        enum Days
        {
            Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
    }
    
}
/* Değişken tanımlarken dikkat edilmesi gereken bazı hususlar şu şekilde:

Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
Değişken isimleri rakamlarla başlayamaz.
Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
Class namespace gibi özel isimler kullanılamaz.
Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir. */