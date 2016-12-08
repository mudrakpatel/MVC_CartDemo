namespace MVC_CartDemo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MenuContext : DbContext
    {
        public MenuContext()
            : base("name=MenuConnection")
        {
        }

        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Menu_List> Menu_Lists { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu_List>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Menu_List>()
                .Property(e => e.LongDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Menu_List>()
                .Property(e => e.IconImage)
                .IsUnicode(false);

            modelBuilder.Entity<Menu_List>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Menu_List>()
                .Property(e => e.ImagePath)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Firstname)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Postalcode)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Total)
                .HasPrecision(10, 5);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitPrice)
                .HasPrecision(10, 4);
        }
    }
}
