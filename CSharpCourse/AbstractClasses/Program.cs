using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer= new SqlServer();
            sqlServer.Add();
            sqlServer.Delete();
            Console.ReadLine();
            Database database = new Database();
        }
        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("ADDED BY DEFAULT");
            }

            public abstract void Delete();
            
        }

        class SqlServer:Database
        {
            public override void Delete()
            {
                 Console.WriteLine("Deleted By Default");
            }
        }
    }
}
