using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
    }
}
