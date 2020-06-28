using Collektions.Core.Entities;
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
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<ExpenditureBreakdown> ExpenditureBreakdowns { get; set; }
        public DbSet<Repayment> Repayments { get; set; }
        public DbSet<RepaymentBreakdown> RepaymentBreakdowns { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}
