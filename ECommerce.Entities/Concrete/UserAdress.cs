using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class UserAdress:IEntity
    {
        public int UserId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }

        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
    }
}
