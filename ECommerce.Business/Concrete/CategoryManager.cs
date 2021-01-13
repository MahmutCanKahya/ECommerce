using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
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

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void DeleteById(int entityID)
        {
            Delete(Get(entityID));
        }

        public Category Get(int entityID)
        {
            return _categoryDal.Get(p => p.Id == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDal.GetList();
        }

        public ICollection<Category> GetAllSubCategories(int level=1)
        {
            var allParentCategories = GetAllParentCategories();
            ICollection<Category> subCategories= allParentCategories;
            for (int i = 0; i < level; i++)
            {
                subCategories= _categoryDal.GetList(p => p.ParentId != null ? subCategories.Contains(p.Parent) : false);
            }
            return subCategories;
        }
        public ICollection<Category> GetAllParentCategories()
        {
            return _categoryDal.GetList(p => p.ParentId == null);
        }
        public ICollection<Category> GetSubCategoriesByParentId(int parentId)
        {
            return _categoryDal.GetList(p => p.ParentId ==parentId);
        }
        public void Insert(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        
    }
}
