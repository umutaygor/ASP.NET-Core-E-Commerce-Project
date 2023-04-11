using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productmanager = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = productmanager.GetProductListWithCategory();
            return View(values);
        }
        public IActionResult ProductReadAll(int ID)
        {
            ViewBag.ID = ID;
            var values = productmanager.GetByID(ID);
            return View(values);
        }
    }
}
