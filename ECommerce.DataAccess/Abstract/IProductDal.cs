using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public List<Product> GetAll();
        public Product Get(int ProductId);
        public List<Product> GetByCategory(int categoryId);

    }
}
