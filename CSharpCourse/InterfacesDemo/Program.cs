using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 5;
            x += y;
            Console.WriteLine(x);
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robor()
            };
            foreach (var woker in workers)
            {
                woker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
        }
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager:IWorker,IEat,ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker:IWorker,ISalary,IEat
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }

    class Robor:IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
