using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class BasketDetail:IEntity
    {
       

        public int ProductId { get; set; }
        public int BasketId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Basket Basket { get; set; }
    }
}
