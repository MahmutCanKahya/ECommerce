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

        public virtual County County { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAdress> UserAdresses { get; set; }
    }
}
