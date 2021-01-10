using ECommerce.Admin.Models;
using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class UserController : Controller
    {
        UserLoginViewModel tempUser = new UserLoginViewModel() {  Email = "admin@ecommerce.com", Password = "123456" };
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

            var isLogin=_userService.Login(user.Email,user.Password);
            if (isLogin!=null)
            {
                /*return Json(data: new { success = true, message = "Başarıyla giriş yapıldı." });*/
                return RedirectToAction("Index", "Home");
            }
            else
            {
                /*return Json(data: new { success = false, message = "E-mail veya şifrenizi yanlış tuşladınız." });*/
                return View();
            }
        }

       
    }
}
