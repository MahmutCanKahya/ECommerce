using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Order:IEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int UserId { get; set; }
        public int OrderDetailId { get; set; }
        public int? ShipperId { get; set; }
        public int AddressId { get; set; }
        public int StatusId { get; set; }
        public decimal? TotalPrice { get; set; }
        public float? Discount { get; set; }

        public virtual Address Address { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
