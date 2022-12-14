using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using CHILDCARE.Models;


namespace CHILDCARE.Models
{
    public class CHILDCAREContext : DbContext
    {
        public CHILDCAREContext(DbContextOptions<CHILDCAREContext> options)
            : base(options) { }

        public DbSet<CHILDCARE.Models.rpt_ccs_provider> rpt_ccs_provider { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Assign default database schema
            modelBuilder.HasDefaultSchema("childcare");
            ///base.OnModelCreating(modelBuilder);
        }

    }
}
