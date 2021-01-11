using ECommerce.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class CategoryController : Controller
    {

        public IActionResult Index()
        {
            List<CategoryModel> categories= new List<CategoryModel>();
            categories.Add(new CategoryModel() { CategoryName = "Erkek giyim"});
            categories.Add(new CategoryModel() { CategoryName = "Kadın giyim" });
            categories.Add(new CategoryModel() { CategoryName = "Kız çocuk giyim" });
            categories.Add(new CategoryModel() { CategoryName = "Erkek çocuk giyim" });
            categories.Add(new CategoryModel() { CategoryName = "Unisex giyim" });
            CategoryListViewModel model = new CategoryListViewModel();
            model.Categories = categories;


            return View(model);

        }
    }
}
