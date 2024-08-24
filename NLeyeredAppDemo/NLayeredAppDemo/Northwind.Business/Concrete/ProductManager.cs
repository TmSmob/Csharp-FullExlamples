using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;
using FluentValidation;
using Northwind.Entities.Concrete;
using ValidationException = FluentValidation.ValidationException;

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

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _IProductDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
           
            return _IProductDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Add(Product product)
        {
            ProductValidator productValidator = new ProductValidator();
            var result= productValidator.Validate(product);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
           _IProductDal.Add(product);
        }

        public void Update(Product product)
        {
            _IProductDal.Update(product);
        }

        public void Delete(Product product)
        {
            try
            {
                _IProductDal.Delete(product);
            }
            catch
            {
                throw new Exception("Silme Gerceklesemedi");
            }
            
        }
    }
}
