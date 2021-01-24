using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Entities
{
    public interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}
