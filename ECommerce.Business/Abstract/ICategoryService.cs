using ECommerce.Entities.Concrete;
using ECommerce.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService:IBaseService<Category>
    {
        ICollection<Category> GetCategoriesByLevel(CategoryLevel level=CategoryLevel.Category);
        ICollection<Category> GetSubCategoriesById(int id = 0, CategoryLevel level = CategoryLevel.Category);

    }
}
