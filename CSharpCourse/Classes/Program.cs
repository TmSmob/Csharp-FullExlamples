using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustamerManager custamerManager = new CustamerManager();
            ProductManager productManager = new ProductManager();
            custamerManager.Add();
            custamerManager.Update();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demirog";

            Customer customer2 = new Customer
            {//CTRL+Space ile cok rahat gorebilirsin.
                Id = 2,
                City = "Istanbul",
                FirstName = "Emirhan",
                LastName = "Yildizer",
            };
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }

    }
}
