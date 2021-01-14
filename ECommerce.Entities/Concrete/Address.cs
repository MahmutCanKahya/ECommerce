using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;


namespace ECommerce.Entities.Concrete
{
    public partial class Address:IEntity
    {
        public Address()
        {
            Orders = new HashSet<Order>();
            UserAdresses = new HashSet<UserAdress>();
        }

        public int? UserId { get; set; }
        public string Detail { get; set; }
        public int? CountyId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual County County { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAdress> UserAdresses { get; set; }
    }
}
