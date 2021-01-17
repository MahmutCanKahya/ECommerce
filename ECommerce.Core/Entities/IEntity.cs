using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Entities
{
    public abstract class IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
