using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Northwind.Entities.Concrete;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Urun ismi bos olamaz");
            RuleFor(p => p.CategoryId).NotEmpty();
            RuleFor(p => p.Unit).NotEmpty();
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
            RuleFor(p => p.Price).GreaterThan(10).When(p =>p.CategoryId==2).WithMessage("Bu kategoride bu fiyati veremezsin");
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Urun ismi `A` ile baslamali");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
