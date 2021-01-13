using ECommerce.Admin.Helper;
using ECommerce.Admin.Models;
using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        IWebHostEnvironment _webHostEnvironment;
        public CategoryController(ICategoryService categoryService, IWebHostEnvironment hostEnvironment)
        {
            _categoryService = categoryService;
            _webHostEnvironment = hostEnvironment;
        }

        public IActionResult Category()
        {
            var model = _categoryService.GetAllParentCategories();
            return View(model);
        }
        public IActionResult SubCategory()
        {
            var model = _categoryService.GetAllSubCategories();
            _categoryService.GetAllParentCategories();
            return View(model);
        }
        public IActionResult SubSubCategory()
        {
            var model = _categoryService.GetAllSubCategories(2);
            return View(model);
        }

        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = new FileUpload().UploadedFile(model.CategoryImage, _webHostEnvironment);
                Category category = new Category
                {
                    Name = model.Name,
                    ImagePath = uniqueFileName
                };
                _categoryService.Insert(category);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(string model)
        {
            return View();
        }

        
        public IActionResult Delete(int id)
        {
            _categoryService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
