using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApplication.Views.ViewComponents.Product
{
    public class OtherProductsFromSupplier:ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke(int ID)
        {
            var values=productManager.GetProductListBySupplier(1);
            return View(values);
        }
    }
}
