using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","Izmir","Adana");
            foreach (var VARIABLE in result)
            {
                Console.WriteLine(VARIABLE);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Emirhan" }, new Customer { FirstName = "Batuhan" }, new Customer { FirstName = "Akin" }, new Customer { FirstName = "Fatma" });
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {
        
    }
    interface IProductDal:IRepository<Product>
    {
    }
    class Customer:IEntity
    {
        public string FirstName { get; set; }
    }
    interface ICustomerDal:IRepository<Customer>
    {
        List<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
    }

    interface IStudent:IRepository<Student>
    {
        
    }

    class Student:IEntity
    {
        
    }

    interface IEntity
    {
        
    }
    interface IRepository<T> where T : class ,IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal:ICustomerDal
    {
            List<Customer> IRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }

        Customer ICustomerDal.Get(int id)
        {
            throw new NotImplementedException();
        }

        void ICustomerDal.Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        void ICustomerDal.Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        void ICustomerDal.Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        List<Customer> ICustomerDal.GetAll()
        {
            throw new NotImplementedException();
        }

        Customer IRepository<Customer>.Get(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Customer>.Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
