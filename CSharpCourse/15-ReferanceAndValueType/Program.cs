using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ReferanceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {//Olay deger uzerinden gider
            int number1 = 10;
            int number2 = 20;
            number2=number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };//Buna bir referans degeri atanir mesela 101 olsun
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balikesir" };//Buna da 102 diyelim
            cities2 = cities1;//101 referans degerini 102 refarans degerinin yerine koy
            cities1[0] = "Istambul";
            Console.WriteLine(cities2[0]);
            Console.ReadLine();
        }
    }
}
