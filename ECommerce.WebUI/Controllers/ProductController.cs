using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class ProductController : Controller
    {
        //List
        public IActionResult Index()
        {
            return View();
        }

        //Detail
        public IActionResult Index(int Id)
        {
            return View();
        }
    }
}
