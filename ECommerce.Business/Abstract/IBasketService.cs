using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface IBasketService
    {
        void AddToBasket(Basket basket, Product product);
        void RemoveFromBasket(Basket basket, int productId);
        List<BasketDetail> List(Basket basket);
        Basket GetBasketByUserId(int userId);
    }
}
