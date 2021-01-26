using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfBasketDal : EfEntityRepositoryBase<Basket, ECommerceContext>, IBasketDal
    {
        public void AddToBasket(Basket basket, Product product)
        {
            using (var context = new ECommerceContext())
            {
                BasketDetail basketDetail = context.BasketDetails.FirstOrDefault(b=>b.ProductId== product.Id);
                if (basketDetail!=null)
                {
                    basketDetail.Quantity++;
                    context.BasketDetails.Update(basketDetail);
                    context.SaveChanges();
                    return;
                }

                context.BasketDetails.Add(new BasketDetail { ProductId=product.Id,BasketId= GetBasketByUserId(1).Id,Quantity = 1});
                context.SaveChanges();
            }
            
        }

        public Basket GetBasketByUserId(int userId)
        {
            using (var context = new ECommerceContext())
            {
                var basket = context.Baskets.Where(p=>p.UserId==userId).Include(p=>p.BasketDetails).ThenInclude(p=>p.Product).FirstOrDefault();
                if (basket==null)
                {
                    basket = new Basket { UserId = userId };
                    context.Baskets.Add(basket);
                }
                context.SaveChanges();
                return basket;
            }
        }

    }
}
