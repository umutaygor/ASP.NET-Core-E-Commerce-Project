using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepository.Insert(category);
        }

        public Category GetByID(int ID)
        {
            return efCategoryRepository.GetByID(ID);
        }

        public List<Category> ListAll()
        {
            return efCategoryRepository.ListAll();
        }

        public void RemoveCategory(Category category)
        {
            efCategoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepository.Update(category);
        }
    }
}
