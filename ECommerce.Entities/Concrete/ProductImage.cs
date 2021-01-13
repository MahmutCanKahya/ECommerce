using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;



namespace ECommerce.Entities.Concrete
{
    public partial class ProductImage:IEntity
    {
        public int ProductId { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual Product Product { get; set; }
    }
}
