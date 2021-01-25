using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IProductService:IBaseService<Product>
    {
        List<Product> GetByCategory(int categoryId);

    }
}
