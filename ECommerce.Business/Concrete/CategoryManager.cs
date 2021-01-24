using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category Get(int entityID)
        {
            return _categoryDal.Get(entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDal.GetList(isAdmin:true);
        }

        public void Delete(Category entity)
        {
            //_categoryDal.Delete(entity);
            entity.IsDeleted = true;
            _categoryDal.Update(entity);
        }

        public void DeleteById(int entityID)
        {
            var category = Get(entityID);
            category.IsDeleted = true;
            _categoryDal.Update(category);
            //Delete(Get(entityID));
        }

        public Category Insert(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public ICollection<Category> GetCategoriesByLevel(CategoryLevel level = CategoryLevel.Category)
        {
            return _categoryDal.GetCategoriesByLevel(level);
        }

        public ICollection<Category> GetSubCategoriesById(int id = 0, CategoryLevel level = CategoryLevel.Category)
        {
            return _categoryDal.GetSubCategoriesById(id,level);
        }
    }
}
