using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class SupplierValidator: AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(x => x.SupplierName).NotEmpty().WithMessage("You must enter a valid name.");
            RuleFor(x => x.SupplierName).Length(2, 50).WithMessage("Your name must between 2 and 50 characters.");
            RuleFor(x => x.SupplierAbout).NotEmpty().WithMessage("You must enter your shop details.");
            RuleFor(x => x.SupplierAbout).Length(5,100).WithMessage("Your shop details must between 5 and 100 characters.");
            RuleFor(x => x.SupplierPassword).NotEmpty().WithMessage("You must set a valid password.");
            //RuleFor(x => x.SupplierPassword).Must(password => Regex.IsMatch(password, "[A-Z]")).WithMessage("Password must contain at least one capital letter.");


        }
    }
}
