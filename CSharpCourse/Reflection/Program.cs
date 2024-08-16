using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dortislem dortislem = new Dortislem(2,3);
            //Console.WriteLine(dortislem.Topla2());
            //Console.WriteLine(dortislem.Topla(3, 4));

            var tip=typeof(Dortislem);
            //Dortislem dortislem = (Dortislem)Activator.CreateInstance(tip,6,7);
            //Console.WriteLine(dortislem.Topla(4,5));
            //Console.WriteLine(dortislem.Topla2());

            var instance = (Dortislem)Activator.CreateInstance(tip, 6, 5);
            MethodInfo methodInfo= instance.GetType().GetMethod("Topla2");
           Console.WriteLine( methodInfo.Invoke(instance,null));

           Console.WriteLine("=============");
            var metodlar = tip.GetMethods();
           foreach (var info in metodlar)
           {
               Console.WriteLine(info.Name);
               foreach (var parameters in info.GetParameters())
               {
                   Console.WriteLine("Parametre " + parameters);
               }

               foreach (var attribute in info.GetCustomAttributes())
               {
                   Console.WriteLine("Attribute Name :" + attribute.GetType().Name);
                }
           }
            
            Console.ReadLine();
        }
    }

    public class Dortislem
    {
        private int _sayi1;
        private int _sayi2;

        public Dortislem(int sayi1,int sayi2)
        {
            _sayi1=sayi1;
            _sayi2=sayi2;
        }

        public Dortislem()
        {
            
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MetodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

    }

    public class MetodNameAttribute:Attribute
    {
        public MetodNameAttribute(string name)
        {
            
        }
    }
}
