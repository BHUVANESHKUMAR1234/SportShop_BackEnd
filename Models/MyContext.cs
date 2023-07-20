using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            modelBuilder.Entity<SportsShop.WebApi.Models.Customer>(b =>
            {
                b.ToTable("customers");

                b.Property(e => e.CustomerId)
                    .HasColumnName("customerid")
                    .UseIdentityAlwaysColumn();

                b.Property(e => e.Address)
                    .HasColumnName("address");
                b.Property(e => e.CustomerName)
                    .HasColumnName("customername");

                b.Property(e => e.ContactNumber)
                    .HasColumnName("contactnumber");

                b.Property(e => e.EmailId)
                    .HasColumnName("emailid");

              
            });

            modelBuilder.Entity<SportsShop.WebApi.Models.Item>(b =>
            {
                b.ToTable("items");

                b.Property(e => e.ItemNumber)
                    .HasColumnName("itemnumber")
                    .UseIdentityAlwaysColumn();

                b.Property(e => e.Color)
                    .HasColumnName("color");

                b.Property(e => e.ItemName)
                    .HasColumnName("itemname");

                b.Property(e => e.Value)
                    .HasColumnName("value");

               
              
            });

            modelBuilder.Entity<SportsShop.WebApi.Models.Order>( b =>
            {
                b.ToTable("orders");
                b.Property(e => e.OrderNumber)
                    .HasColumnName("ordernumber")
                    .UseIdentityAlwaysColumn();

                b.Property(e => e.CustomerId)
                    .HasColumnName("customerid");

                b.Property(e => e.ItemNumber)
                    .HasColumnName("itemnumber");

                b.Property(e => e.OrderDate)
                    .HasColumnName("orderdate");


                b.HasIndex("CustomerId");

                b.HasIndex("ItemNumber");

               
            });

            //modelBuilder.Entity("SportsShop.WebApi.Models.Order", b =>
            //{
            //    b.HasOne("SportsShop.WebApi.Models.Customer", "Customer")
            //        .WithMany()
            //        .HasForeignKey("CustomerId");

            //    b.HasOne("SportsShop.WebApi.Models.Item", "Item")
            //        .WithMany()
            //        .HasForeignKey("ItemNumber");
            //});


            base.OnModelCreating(modelBuilder);
        }


    }
}
