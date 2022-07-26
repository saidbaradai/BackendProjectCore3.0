using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 30);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryID == 1);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Must start with A");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith('A');
        }
    }
}