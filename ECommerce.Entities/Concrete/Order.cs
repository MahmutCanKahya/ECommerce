using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderDetailId { get; set; }
        public int? ShipperId { get; set; }
        public int AddressId { get; set; }
        public int StatusId { get; set; }
        public decimal? TotalPrice { get; set; }
        public float? Discount { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }

        public virtual Address Address { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual Shipper Shipper { get; set; }
        public virtual OrderStatus Status { get; set; }
        public virtual User User { get; set; }
    }
}
