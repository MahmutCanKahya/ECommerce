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

        public User Get(int entityID)
        {
            return _userDal.Get(p => p.Id == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userDal.GetList();
        }

        public User Insert(User entity)
        {
            return _userDal.Add(entity);
        }

        public void Update(User entity)
        {
            _userDal.Update(entity);
        }
        public User Login(string Email, string Password)
        {
            return _userDal.Get(p => p.Email == Email && p.Password == Password);
        }

        public void DeleteById(int entityID)
        {
            Delete(Get(entityID));
        }

        public void Delete(User entity)
        {
            _userDal.Delete(entity);
        }
    }
}
