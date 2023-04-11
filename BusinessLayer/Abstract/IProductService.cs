using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void RemoveProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> ListAll();
        Product GetByID(int ID);
        List<Product> GetProductListWithCategory();
     


    }
}
