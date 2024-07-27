using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();//Array List Olustusturma
            //Lists();//Liste olusturma            //Liste Arraylist ile arasinaki fark tip guvenligidir.Array listte Her tipip alir list te ise sadece belirtilen tip ile calisir.
            //ListInClass();//Clasta list eleman ekleme ve okuma
            Dictionarys();
            Console.ReadLine();
        }

        private static void Dictionarys()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            Console.WriteLine(dictionary["table"]);
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine("________");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________");

            foreach (var item1 in dictionary)
            {
                Console.WriteLine(item1.Key);

            }
            Console.WriteLine("________");

            foreach (var item2 in dictionary)
            {
                Console.WriteLine(item2.Value);

            }
            Console.WriteLine("________");
        }

        private static void ListInClass()
        {

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });


            //YA DA


            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Engin" },
                new Customer { Id = 2, FirstName = "Derin" }
            };



            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);



            customers.AddRange(new Customer[2]//Listeye Liste ekleme
            {
                new Customer{Id = 4,FirstName = "Ali"},
                new Customer{Id = 5,FirstName = "Ayse"},
            });




            Console.WriteLine("{0}.Sirada ", customers.IndexOf(customer2));
            Console.WriteLine("Sondan {0}.Sirada ", customers.LastIndexOf(customer2));
            customers.Insert(0, customer2);
            customers.Remove(customer2);
            customers.RemoveAll(c => c.FirstName == "Salih");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);

            }

            //customers.Clear();//Listeyi siler

            var count = customers.Count;
            Console.WriteLine(count);

        }

        private static void Lists()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Istanbul");
            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add("Istanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }


}
