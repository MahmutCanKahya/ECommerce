using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Brand:IEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
