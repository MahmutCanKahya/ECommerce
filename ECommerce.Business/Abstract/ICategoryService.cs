using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Business.Abstract
{
    public interface ICategoryService:IBaseService<Category>
    {
        ICollection<Category> GetAllParentCategories();
        ICollection<Category> GetAllSubCategories(int level=1);
        ICollection<Category> GetSubCategoriesByParentId(int parentId);
    }
}
