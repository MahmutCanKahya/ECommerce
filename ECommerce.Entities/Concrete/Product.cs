using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Product:IEntity, ISoftDeletable
    {
        public Product()
        {
            BasketDetails = new HashSet<BasketDetail>();
            OrderDetails = new HashSet<OrderDetail>();
            ProductImages = new HashSet<ProductImage>();
        }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        [Display(Name ="Product Name")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public float Discount { get; set; }
        public string Description { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<BasketDetail> BasketDetails { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
    }
}
