using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}