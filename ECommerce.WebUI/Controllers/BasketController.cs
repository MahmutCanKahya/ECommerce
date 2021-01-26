using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.Controllers
{
    public class BasketController : Controller
    {
        private IProductService _productService;
        private IBasketService _basketService;

        public BasketController(IProductService productService, IBasketService basketService)
        {
            _productService = productService;
            _basketService = basketService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AddToBasket(int productId)
        {
            var productToBeAdded = _productService.Get(productId);

            var basket = _basketService.GetBasketByUserId(1); //TODO: GetCartByUserID

            _basketService.AddToBasket(basket , productToBeAdded);

            ////////_cartSessionService.SetCart(cart);



            return RedirectToAction("Index", "Home");
        }
    }
}
