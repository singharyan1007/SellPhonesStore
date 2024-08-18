using Microsoft.EntityFrameworkCore;
using SellPhonesStore.Entities;
using System.Runtime.CompilerServices;

namespace SellPhonesStore.DataAccess
{
    public class SellPhonesStoreDBContext:DbContext
    {
        public SellPhonesStoreDBContext(DbContextOptions<SellPhonesStoreDBContext> options):base(options) { }

        public SellPhonesStoreDBContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //If the client does not provide any options builder then only 
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SellPhonesDB;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
           .HasMany(c => c.CustomerOrders)
           .WithOne(co => co.Customer)
           .HasForeignKey(co => co.CustomerId);

            // Configure unidirectional relationship
            modelBuilder.Entity<CustomerOrder>()
                .HasMany(co => co.OrderedPhones)
                .WithOne(); // No reference back to CustomerOrder

            modelBuilder.Entity<OrderedPhone>()
                .HasOne(op => op.Phone)
                .WithOne()
                .HasForeignKey<OrderedPhone>(op => op.PhoneId);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<OrderedPhone> OrderedPhones { get; set; }
        public DbSet<Phone> Phones { get; set; }

    }
}
