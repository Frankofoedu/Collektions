using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Collektions.Core.Entities;

namespace Collektions.Infrastructure.Data
{
    class CollektionsContext : DbContext
    {
        public CollektionsContext(DbContextOptions<CollektionsContext> options) : base(options)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
