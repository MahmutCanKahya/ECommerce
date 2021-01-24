using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IBaseService<T> where T:IEntity
    {
        T Insert(T entity);
        void DeleteById(int entityID);
        void Delete(T entity);
        void Update(T entity);
        T Get(int entityID);
        ICollection<T> GetAll();
    }
}
