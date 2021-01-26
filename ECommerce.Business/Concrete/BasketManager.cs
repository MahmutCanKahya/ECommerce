using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void AddToBasket(Basket cart, Product product)
        {
             _basketDal.AddToBasket(cart, product);
        }

        public Basket GetBasketByUserId(int userId)
        {
            return _basketDal.GetBasketByUserId(userId);
        }

        public List<BasketDetail> List(Basket cart)
        {
            throw new NotImplementedException();
        }

        public void RemoveFromBasket(Basket cart, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
