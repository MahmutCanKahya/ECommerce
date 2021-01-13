using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IUserService:IBaseService<User>
    {
        User Login(string Email, string Password);
    }
}
