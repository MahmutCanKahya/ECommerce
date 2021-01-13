using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;


namespace ECommerce.Entities.Concrete
{
    public partial class Province:IEntity
    {
        public Province()
        {
            Counties = new HashSet<County>();
        }

        public string Name { get; set; }

        public virtual ICollection<County> Counties { get; set; }
    }
}
