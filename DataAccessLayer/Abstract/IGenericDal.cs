﻿using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> ListAll(Expression<Func<T,bool>>filter=null);
        T GetByID(int ID);
    }
}
