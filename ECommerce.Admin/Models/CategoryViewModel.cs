

using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IFormFile CategoryImage { get; set; }
        public string ImagePath { get; set; }
        public int ParentId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Category> SubCategories { get; set; }

    }
}
