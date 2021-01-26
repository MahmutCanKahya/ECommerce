using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class User:IEntity
    {
        public User()
        {
            Addresses = new HashSet<Address>();
            Baskets = new HashSet<Basket>();
            Orders = new HashSet<Order>();
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int? RoleId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
