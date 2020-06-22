using Collektions.Core.Entities;
using Collektions.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Collektions.Server.Data
{
    public class CollektionDbContext : ApiAuthorizationDbContext<HouseMate>
    {
        public CollektionDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<House> Houses { get; set; }
    }
}
