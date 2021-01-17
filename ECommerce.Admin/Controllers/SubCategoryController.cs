using ECommerce.Admin.Helper;
using ECommerce.Admin.Models;
using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.Enum;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        ICategoryService _categoryService;
        IWebHostEnvironment _webHostEnvironment;
        public SubCategoryController(ICategoryService categoryService, IWebHostEnvironment hostEnvironment)
        {
            _categoryService = categoryService;
            _webHostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            var model = _categoryService.GetCategoriesByLevel(CategoryLevel.SubCategory);
            return View(model);
        }
        public IActionResult Insert()
        {

            var model = new CategoryViewModel { Categories=_categoryService.GetCategoriesByLevel(CategoryLevel.Category) };
            return View(model);
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
                    ImagePath = uniqueFileName,
                    ParentId = model.CategoryId
                };
                _categoryService.Insert(category);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Update(int id)
        {
            var category = _categoryService.Get(id);
            CategoryViewModel model = new CategoryViewModel
            {
                Name = category.Name,
                ImagePath = category.ImagePath,
                CategoryId=(int)category.ParentId,
                Categories = _categoryService.GetCategoriesByLevel(CategoryLevel.Category)
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Update(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = new FileUpload().UploadedFile(model.CategoryImage, _webHostEnvironment);

                Category category = _categoryService.Get(model.Id);
                category.ImagePath = string.IsNullOrEmpty(uniqueFileName )?  category.ImagePath: uniqueFileName ;
                category.Name = model.Name;
                category.ParentId = model.CategoryId;
                _categoryService.Update(category);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _categoryService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
