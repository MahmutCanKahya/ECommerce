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
        }

        public int? UserId { get; set; }
        public string Name { get; set; }
        public string FullAddress { get; set; }
        public int CountyId { get; set; }

        public virtual County County { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
