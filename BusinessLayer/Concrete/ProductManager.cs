using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void AddProduct(Product product)
        {
            _productDal.Insert(product);
        }

        public Product GetByID(int ID)
        {
            return _productDal.GetByID(ID);
        }

        public List<Product> GetProductListWithCategory()
        {
            return _productDal.GetProductListWithCategory();
        }

     
        public List<Product> ListAll()
        {
            return _productDal.ListAll();
        }

        public void RemoveProduct(Product product)
        {
            _productDal.Delete(product);
        }

        public void UpdateProduct(Product product)
        {
            _productDal.Update(product);
        }
    }
}
