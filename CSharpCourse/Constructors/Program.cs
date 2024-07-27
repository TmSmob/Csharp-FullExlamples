using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Computer");

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();


            Teacher.Number = 10;

            Utilities.Validate();
            Manager.DoSometing();
            Manager manager = new Manager();
            manager.DoSometing2();

            Console.ReadLine();

        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }


    }
    class Product
    {
        public Product()
        {

        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = Id;
            _name = Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass//Consttructors ile Base parametre gonderme
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} Message", _entity);
        }
    }


    class PersonManager : BaseClass//
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher//Static class prop ekleme
    {
        public static int Number { get; set; }
    }

    static class Utilities//Static class Cagirimi
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is Done");
        }
    }

    class Manager//Sinif Static degil fonksiyonlardan birisi static digeri degilse
    {
        public static void DoSometing()
        {
            Console.WriteLine("1 is Done");
        }

        public void DoSometing2()
        {
            Console.WriteLine("2 is Done");

        }
    }




}
