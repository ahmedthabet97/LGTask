using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDB
{
    public class Context : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Properties> Propertiess { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<CategoryPropertiesValues> PropertiesValues{get;set;}
        public Context(DbContextOptions option) : base(option) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Properties>()
            //     .HasOne(c => c.PropertiesValues)
            //     .WithMany(b => b.properties).HasForeignKey(f => f.PropId);
            ////modelBuilder.Entity<Device>()
            ////       .HasOne(c => c.PropertiesValues)
            ////       .WithMany(b => b.devices);
            //modelBuilder.Entity<Category>()
            //       .HasOne(c => c.PropertiesValues)
            //       .WithMany(b => b.categories).HasForeignKey(f=>f.CatId);
            //modelBuilder.Entity<Device>()
            //      .HasOne(c => c.PropertiesValues)
            //      .WithMany(b => b.devices).HasForeignKey(f => f.DevId);
            modelBuilder.Entity<Category>()
                .HasMany(d => d.Devices)
                .WithOne(c => c.category).HasForeignKey(f => f.CategoryId).IsRequired().OnDelete(DeleteBehavior.Cascade);
            //modelBuilder.Entity<CategoryPropertiesValues>().
            //    HasMany(d => d.devices).
            //    WithOne(p => p.PropertiesValues);
            //modelBuilder.Entity<CategoryPropertiesValues>().
            //    HasMany(d => d.categories).
            //    WithOne(p => p.PropertiesValues);
            //modelBuilder.Entity<CategoryPropertiesValues>().
            //    HasMany(d => d.properties).
            ////    WithOne(p => p.PropertiesValues);
            modelBuilder.Entity<CategoryPropertiesValues>()
                .HasKey(b => new { b.propertyId, b.CategoryId, b.DeviceId });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB;Integrated Security=True");
        }
    }
}
