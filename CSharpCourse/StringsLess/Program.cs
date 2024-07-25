using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsLess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My Name\'s \"Engin\" \\Demirog";
            var result = sentence.Length;
            var result2=sentence.Clone();

            bool result3=sentence.EndsWith("g");//Ne ile bitiyor
            bool result4 = sentence.StartsWith("My Name");//Ne ile basliyor
            var result5 = sentence.IndexOf("Name");//Kacinci indexinde
            var result6 = sentence.LastIndexOf(" ");//Sondan kacinci
            var result7 = sentence.Insert(0, "Hello, ");//Metne belirli indexten sonra ekleme yapar
            var result8 = sentence.Substring(3,4);//Metni 3.indexten sonra 4 karakter gosterir
            var result9=sentence.ToLower();//Hepsi Kucuk
            var result10=sentence.ToUpper();//Hepsi Buyuk
            var result11=sentence.Replace(" ","-");//Bosluklari - ile degistirir
            var result12=sentence.Remove(2,5);//2.indexten sonrasini siler
            Console.WriteLine(result2);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            string city2 = "Istanbul";
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
