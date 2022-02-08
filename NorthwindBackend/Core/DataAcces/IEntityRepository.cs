using Core.Entities;
using NLog.Filters;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace Core.DataAcces
{
  public  interface IEntityRepository<T> where T:class,IEntity,new() //t class olmalı demek değil. t referans tip olmalı.
    {
        T Get(Expression<Func<T, bool >> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter= null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
