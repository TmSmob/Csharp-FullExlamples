using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _IProductDal;

        public ProductManager(IProductDal IProductDal)
        {
            _IProductDal = IProductDal;
        }

        public List<Product> GetAll()
        {
            //Business Code
            
            return _IProductDal.GetAll();
        }
    }
}
