using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TestProject.DAL.Entities;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Context
{
    public class TestProjectContext : DbContext
    {
        public TestProjectContext(DbContextOptions<TestProjectContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> User { get; set; }

        public DbSet<ParameterMaster> ParameterMaster { get; set; }

        public DbSet<ParameterDetail> ParameterDetail { get; set; }

        public DbSet<StockDetail> StockDetail { get; set; }

        public DbSet<StockMaster> StockMaster { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<Contract> Contract { get; set; }

        public DbSet<Project> Project { get; set; }

        public DbSet<ProjectExplore> ProjectExplore { get; set; }

        public DbSet<ProjectManager> ProjectManager { get; set; }

        public DbSet<ItemDemandMaster> ItemDemandMaster { get; set; }

        public DbSet<ItemDemandDetail> ItemDemandDetail { get; set; }

        public DbSet<MenuRole> MenuRole { get; set; }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<PayoffMaster> PayoffMaster { get; set; }
        public DbSet<PayoffDetail> PayoffDetail { get; set; }
        public DbSet<PayoffDefault> PayoffDefault { get; set; }
        public DbSet<PayoffControl> PayoffControl { get; set; }
        public object WindowsIdentity { get; private set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            System.Collections.Generic.IEnumerable<Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry> Entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            string identity = "";
            DateTime date = DateTime.Now;
            string ip = "";

            foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry item in Entries)
            {
                EntityBase entity = item.Entity as EntityBase;
                if (item != null)
                {
                    if (item.State == EntityState.Added)
                    {
                        entity.CREATED_USER_IP = ip;
                        entity.ISACTIVE = true;
                        entity.MACHINENAME_MACHINEIDENTITY = identity;
                        entity.CREATED_USER_ID = 0;
                        entity.CREATED_DATE = date;
                    }
                }
            }
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

    }
}
