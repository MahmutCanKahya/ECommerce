using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.WebUI.ViewComponents
{
    public class BasketSummaryViewComponent : ViewComponent
    {
        private IBasketDal _basketDal;

        public BasketSummaryViewComponent(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public ViewViewComponentResult Invoke()
        {
            Basket model = _basketDal.GetBasketByUserId(1);

            return View(model);
        }
    }
}
