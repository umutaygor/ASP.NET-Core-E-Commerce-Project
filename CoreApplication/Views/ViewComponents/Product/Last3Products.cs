using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Views.ViewComponents.Product
{
    public class Last3Products: ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());

        public IViewComponentResult Invoke()
        {
            var values = productManager.GetLast3Products();
            return View(values);
        }
    }
}
