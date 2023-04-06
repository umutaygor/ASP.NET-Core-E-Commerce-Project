using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public T GetByID(int ID)
        {
            using var c = new Context();
            return c.Set<T>().Find(ID);
        }

        public void Insert(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public List<T> ListAll(Expression<Func<T,bool>>filter=null)
        {
            
            using (var context = new Context())
            {
                return filter == null
                    ? context.Set<T>().ToList()   //List all If there is no filter
                    : context.Set<T>().Where(filter).ToList();   //List based on filter

            }
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
