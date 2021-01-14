﻿using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace ECommerce.Entities.Concrete
{
    public partial class User:IEntity
    {
        public User()
        {
            Orders = new HashSet<Order>();
            UserAdresses = new HashSet<UserAdress>();
        }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public int? RoleId { get; set; }
        public bool IsDeleted { get; set; }
        public Guid RowGuid { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CreateUser { get; set; }
        public int? UpdateUser { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAdress> UserAdresses { get; set; }
    }
}
