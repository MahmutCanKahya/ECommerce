using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetUserById(int Id)
        {
            return _userDal.Get(p => p.Id == Id);
        }

        public User Login(string Email, string Password)
        {
            return _userDal.Get(p => p.Email == Email && p.Password == Password);
        }
    }
}
