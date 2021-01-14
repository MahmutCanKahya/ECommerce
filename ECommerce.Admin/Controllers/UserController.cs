using ECommerce.Admin.Filters;
using ECommerce.Admin.Models;
using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
   
    public class UserController : Controller
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel user)
        {
            var _user=_userService.Login(user.Email,user.Password);
            if (_user != null)
            {
                //Sessiona giriş yapan kullanıcının id'sini kayıt eder.
                HttpContext.Session.SetString("Login", (_user.Id).ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

       
    }
}
