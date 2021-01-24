using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            ProductImages = new HashSet<IFormFile>();
            ProductImagesPath = new HashSet<string>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<IFormFile> ProductImages { get; set; }
        public ICollection<string> ProductImagesPath { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int SubSubCategoryId { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
        public float Discount { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }


        public ICollection<Category> Categories { get; set; }
        public ICollection<Category> SubCategories { get; set; }
        public ICollection<Category> SubSubCategories { get; set; }
    }
}
