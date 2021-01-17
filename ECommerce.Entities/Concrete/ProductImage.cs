using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;



namespace ECommerce.Entities.Concrete
{
    public partial class ProductImage:IEntity
    {
        public int ProductId { get; set; }
        public string Path { get; set; }

        public virtual Product Product { get; set; }
    }
}
