using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Controllers
{
    public class RegisterController : Controller
    {
        SupplierManager supplierManager = new SupplierManager(new EfSupplierRepository());
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(Supplier supplier)
        {
            SupplierValidator supplierValidator = new SupplierValidator();
            ValidationResult results = supplierValidator.Validate(supplier);
            if (results.IsValid)
            {
                supplier.SupplierStatus = true;
                supplierManager.AddSupplier(supplier);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
