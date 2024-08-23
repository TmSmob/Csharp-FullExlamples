using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Norhtwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Leptop", Price = 1, Unit = "No info" }
            };
            return products;
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
