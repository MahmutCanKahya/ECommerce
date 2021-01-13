using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Category:IEntity
    {
        public Category()
        {

            InverseParent = new HashSet<Category>();
            Products = new HashSet<Product>();
        }
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Profile Picture")]
        public string ImagePath { get; set; }
        public int? ParentId { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> InverseParent { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
