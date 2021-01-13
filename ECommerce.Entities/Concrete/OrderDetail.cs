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
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
