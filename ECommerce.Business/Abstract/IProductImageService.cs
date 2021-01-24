using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IProductImageService
    {
        ProductImage Insert(ProductImage entity);
    }
}
