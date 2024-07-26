using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlServerCustomerDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();


            Students students = new Students
            {
                id = 1,
                FirstName = "Batuhan",
                LastName = "Yildizer",
                Departmant = "HighSchool"
            };
            personManager.Add(students);
        }
    }

    interface IPerson
    {
        int id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customers : IPerson
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Students : IPerson
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
