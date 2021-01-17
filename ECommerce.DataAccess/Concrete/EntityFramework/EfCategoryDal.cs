using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using ECommerce.Entities.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,ECommerceContext>,ICategoryDal
    {
        public ICollection<Category> GetCategoriesByLevel(CategoryLevel level = CategoryLevel.Category)
        {
            using (var context = new ECommerceContext())
            {
                var parentCategories = context.Categories.Include(p => p.Parent).ToList().Where(p=>p.ParentId==null&&!p.IsDeleted).ToList(); // ParentId si olmayan en tepedeki kategorileri ilişkisel olarak getirir.
                ICollection<Category> categories = parentCategories;
                if (level == 0) return parentCategories;
                for (int i = 0; i < (int)level; i++)
                {
                    categories = context.Categories.Include(p => p.Parent).ToList().Where(p=>categories.Contains(p.Parent) && !p.IsDeleted).ToList();//Tüm tabloda sonraki leveli bulmak için bir önceki level ile karşılaştırılmaktadır.
                }
                return categories;
            }
            
        }

        public ICollection<Category> GetSubCategoriesById(int id=0,CategoryLevel level=CategoryLevel.Category)
        {
            return GetCategoriesByLevel(level).Where(p=>p.ParentId==id).ToList();
        }
        
        public Category Get(int id)
        {
            using (var context = new ECommerceContext())
            {
                var category = context.Categories.Include(p => p.Parent).ToList().FirstOrDefault(p=>p.Id==id);
                return category;
            }
        }
    }
}
