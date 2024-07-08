using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadLine();

            //Cok Boyutlu Diziler

            string[,] regions = new string[5, 3]
            //regions[0, 0] = "Istanbul";
            //veya
            {
                { "Istanbul", "Izmit", "Balikesir" },
                { "Ankara", "Eskisehir", "Konya" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Samsun", "Trabzon" },
                { "Izmir", "Mugla", "Manisa" }
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0;j <= regions.GetUpperBound(1);j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********************");
            }
            Console.ReadLine();
        }
    }
}
