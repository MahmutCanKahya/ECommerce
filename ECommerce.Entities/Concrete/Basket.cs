using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Basket:IEntity, ISoftDeletable
    {
        public Basket()
        {
            BasketDetails = new HashSet<BasketDetail>();
        }
        public int UserId { get; set; }
        

        public virtual User User { get; set; }
        public virtual ICollection<BasketDetail> BasketDetails { get; set; }
    }
}
