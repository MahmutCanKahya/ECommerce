using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            var category = Get(entityID);
            category.IsDeleted = true;
            _productDal.Update(category);
            //Delete(Get(entityID));
        }

        public Product Get(int entityID)
        {
            return _productDal.Get(entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetByCategory(categoryId);
        }

        public Product Insert(Product entity)
        {
            return _productDal.Add(entity);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
