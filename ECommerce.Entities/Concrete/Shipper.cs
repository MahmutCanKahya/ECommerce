using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Shipper:IEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
