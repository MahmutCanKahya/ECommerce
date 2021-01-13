

using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Admin.Models
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public IFormFile CategoryImage { get; set; }
    }
}
