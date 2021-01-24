using ECommerce.Admin.Helper;
using ECommerce.Admin.Models;
using ECommerce.Business.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.Enum;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        IBrandService _brandService;
        ICategoryService _categoryService;
        IProductImageService _productImageService;
        IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductService productService, IWebHostEnvironment webHostEnvironment, IBrandService brandService, ICategoryService categoryService, IProductImageService productImageService)
        {
            _productService = productService;
            _brandService = brandService;
            _categoryService = categoryService;
            _productImageService = productImageService;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var model = _productService.GetAll();
            return View(model);
        }

        public IActionResult Edit(int ProductId)
        {

            var model = new ProductViewModel
            {
                Categories = _categoryService.GetCategoriesByLevel(CategoryLevel.Category),
                SubCategories = _categoryService.GetCategoriesByLevel(CategoryLevel.SubCategory),
                SubSubCategories = _categoryService.GetCategoriesByLevel(CategoryLevel.SubSubCategory),
            };
            if (ProductId != 0)
            {

                var product = _productService.Get(ProductId);
                model.Id = product.Id;
                model.Name = product.Name;
                model.Description = product.Description;
                model.Price = product.Price;
                model.Discount = product.Discount;
                model.Stock = product.Stock;
                model.BrandName = product.Brand.Name;
                model.CategoryId = _categoryService.Get(product.CategoryId).Parent.Parent.Id;
                model.SubCategoryId = _categoryService.Get(product.CategoryId).Parent.Id;
                model.SubSubCategoryId = product.CategoryId;
                model.ProductImagesPath = new List<string> { product.ProductImages.Count==0?"/statics/no_product.jpg":product.ProductImages.Last().Path };
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = new FileUpload().UploadedFile(model.ProductImages.FirstOrDefault(), _webHostEnvironment);
                

                if (model.Id == 0)
                {
                    Product product = new Product
                    {
                        Name = model.Name,
                        CategoryId = model.SubSubCategoryId,
                        Description = model.Description,
                        Discount = model.Discount,
                        Stock = model.Stock,
                        Price = model.Price,
                        BrandId = _brandService.Insert(new Brand { Name = model.BrandName }).Id
                    };
                    var newProduct = _productService.Insert(product);
                    ProductImage image = new ProductImage
                    {
                        Path = uniqueFileName,
                        ProductId = newProduct.Id
                    };
                    _productImageService.Insert(image);
                }
                else
                {
                    var product = _productService.Get(model.Id);
                    product.Name = model.Name;
                    product.CategoryId = model.SubSubCategoryId;
                    product.Description = model.Description;
                    product.Discount = model.Discount;
                    product.Stock = model.Stock;
                    product.Price = model.Price;
                    product.BrandId = _brandService.Insert(new Brand { Name = model.BrandName }).Id;
                    ProductImage image = new ProductImage
                    {
                        Path = uniqueFileName,
                        ProductId = model.Id

                    };
                    _productImageService.Insert(image);
                    _productService.Update(product);
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            _productService.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }

        public JsonResult LoadSubCategory(int CategoryId)
        {
            var subcategories = _categoryService.GetSubCategoriesById(CategoryId, CategoryLevel.SubCategory);
            return Json(new SelectList(subcategories, "Id", "Name"));
        }

        public JsonResult LoadSubSubCategory(int CategoryId)
        {
            var subcategories = _categoryService.GetSubCategoriesById(CategoryId, CategoryLevel.SubSubCategory);
            return Json(new SelectList(subcategories, "Id", "Name"));
        }
    }
}
