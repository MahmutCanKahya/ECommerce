using ECommerce.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class UserController : Controller
    {
        UserViewModel tempUser = new UserViewModel() { Password = "123456", UserName = "kahya" };
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserViewModel user)
        {
            if (user.UserName==tempUser.UserName && user.Password == tempUser.Password)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
        }

       
    }
}
