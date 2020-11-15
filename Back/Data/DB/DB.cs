using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data.DB
{
   public class DB : IdentityDbContext
   {
      public DB()
      {

      }

      public DB(DbContextOptions options) : base(options) { }

      public virtual DbSet<Data.Models.Camping> Camping { get; set; }
      public virtual DbSet<Data.Models.Client> Client { get; set; }

        public virtual DbSet<Data.Models.Location> Location { get; set; }
        public virtual DbSet<Data.Models.Facilities> Facilities { get; set; }

    }
}
