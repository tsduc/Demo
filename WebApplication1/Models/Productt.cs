using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Productt
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        public bool? IsLike { get; set; }

        public string Image { get; set; }

        public DateTime CreateDate { get; set; }
    }
}