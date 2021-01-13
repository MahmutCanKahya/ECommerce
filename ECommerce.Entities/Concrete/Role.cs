using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class Role:IEntity
    {
        public string Name { get; set; }
    }
}
