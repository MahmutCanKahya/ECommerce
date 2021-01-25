using ECommerce.Business.Abstract;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private IProductService _productService;

        public ProductListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public ViewViewComponentResult Invoke(int page = 1, int category = 0)
        {
            int pageSize = 10;

            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };

            return View(model);
        }

    }
}
