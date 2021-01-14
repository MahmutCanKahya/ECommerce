using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class County:IEntity
    {
        public County()
        {
            Addresses = new HashSet<Address>();
        }

        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
