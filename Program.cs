using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Operatörler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 10;
            int sayi3 = 10;

            //& (ve) Operatörü=> koşul sağlanmasa da diğer koşulları kontroller eder.
            if (sayi1 == 10 & sayi2 == 10 & sayi3 == 10)//true
            {
                Console.WriteLine("sayılar 10'a eşittir.");
            }
            //&&(Mutlak ve) => koşul sağlanmazsa diğer koşulları kontrol etmez.

            if (sayi1 == 5 && sayi2 == 10 && sayi3 == 10)
            {
                Console.WriteLine("sayılar 10'a eşittir");
            }
            else
            {
                Console.WriteLine("sayılar 10'a Eşit DEĞİLDİR.");
            }
            string meyve = "elma";
            if (meyve == "elma" || meyve == "armut" || meyve == "çilek")//true
            {
                Console.WriteLine("değerler arasında elma var.");
            }
            string tatli = "baklava";
            string icecek = "çay";

            if (meyve == "elma" && tatli == "baklava" && icecek == "çay")//false
            {
                Console.WriteLine("bütün değerler eşittir");
            }
            Console.Read();
        }
    }
}
