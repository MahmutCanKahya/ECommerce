using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class OrderDetail:IEntity
    {
        public OrderDetail()
        {
            Orders = new HashSet<Order>();
        }

        public int? ProductId { get; set; }
        public int? Amount { get; set; }
        public decimal? TotalPrice { get; set; }
        public float? Discount { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
