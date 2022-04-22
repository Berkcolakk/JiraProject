using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TestProject.DAL.DataSeeding;
using TestProject.DAL.Entities;
using TestProject.DAL.Entities.Base;

namespace TestProject.DAL.Context
{
    public class TestProjectContext : DbContext
    {
        public TestProjectContext(DbContextOptions<TestProjectContext> options) : base(options) { }

        public TestProjectContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.;Database=TestProjectDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=TestProjectDB;Trusted_Connection=True;");
        }
        public DbSet<User> User { get; set; }

        public DbSet<UserRole> UserRole { get; set; }

        public DbSet<Roles> Roles { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<MenuRole> MenuRole { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            System.Collections.Generic.IEnumerable<Microsoft.EntityFrameworkCore.Metadata.IMutableForeignKey> cascadeFKs = modelBuilder.Model.GetEntityTypes()
            .SelectMany(t => t.GetForeignKeys())
            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (Microsoft.EntityFrameworkCore.Metadata.IMutableForeignKey fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Company>().HasData(Seeding.AllCompanyCreate());
            modelBuilder.Entity<Roles>().HasData(Seeding.AllRolesCreate());
            modelBuilder.Entity<User>().HasData(Seeding.AllUserCreate());
            modelBuilder.Entity<Menu>().HasData(Seeding.AllMenuCreate());
            modelBuilder.Entity<UserRole>().HasData(Seeding.AllUserRoleCreate());
            modelBuilder.Entity<MenuRole>().HasData(Seeding.AllMenuRoleCreate());

            base.OnModelCreating(modelBuilder);
        }
        public void Commit()
        {
            SaveChangesAsync();
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
                        entity.CrtUserIP = ip;
                        entity.IsActive = true;
                        entity.MachineName = identity;
                        entity.CrtUserID = 0;
                        entity.CrtDate = date;
                    }
                    else if (item.State == EntityState.Modified || item.State == EntityState.Deleted)
                    {
                        entity.UpdUserIP = ip;
                        entity.UpdUserID = 0;
                        entity.UpdDate = date;
                    }
                }
            }
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


    }
}
