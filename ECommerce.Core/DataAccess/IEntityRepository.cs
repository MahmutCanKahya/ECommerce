using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.Core.DataAccess
{
    public interface IEntityRepository<T> where T: IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter=null,bool isAdmin=false);
        List<T> GetList(Expression<Func<T, bool>> filter = null, bool isAdmin = false);
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
    }
}
