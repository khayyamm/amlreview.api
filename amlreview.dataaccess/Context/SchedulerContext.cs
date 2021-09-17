using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace amlreview.dataaccess
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext( DbContextOptions options) : base(options)
        {
        }


        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanySchedule> CompanySchedules { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CompanySchedule>()
               .HasOne<Company>(s => s.Company)
               .WithMany(g => g.Schedules)
               .HasForeignKey(f => f.CompanyId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
