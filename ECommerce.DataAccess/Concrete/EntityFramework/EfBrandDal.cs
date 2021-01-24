using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand,ECommerceContext>,IBrandDal
    {
    }
}
