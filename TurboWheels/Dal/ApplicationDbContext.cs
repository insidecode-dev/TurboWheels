using Microsoft.EntityFrameworkCore;

namespace TurboWheels.Dal
{

    public class ApplicationDbContext : DbContext
    {        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-TOURGOO\SQLEXPRESS;Database=TurboWheelsDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //Server = localhost; Database = master; Trusted_Connection = True;
        }
        //LAPTOP-BAUGC557\MSSQLSERV
        //DESKTOP-TOURGOO\SQLEXPRESS
        //LAPTOP-BAUGC557\MSSQLSERV

        //public DbSet<CargoCompany> CargoCompanies { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Expense> Expenses { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Report> Reports { get; set; }
        //public DbSet<Stock> Stocks { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<MarketValue> MarketValues { get; set; }
        //public DbSet<CustomerLimits> CustomerLimits { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Expense>(entity =>
            //{
            //    entity.Property(e => e.ChargePrice)
            //        .HasColumnType("decimal(6, 2)"); // Example precision and scale (adjust as needed)
            //                                         // Configure other properties similarly if necessary
            //});

            //// Configure other entities and properties here...

            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.Property(e => e.CargoPrice)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.Property(e => e.PriceOfPerItem)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.Property(e => e.TotalPriceOfAllItems)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Order>(entity =>
            //{
            //    entity.Property(e => e.TotalPriceOfPerItem)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Report>(entity =>
            //{
            //    entity.Property(e => e.PriceOfPerItem)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Report>(entity =>
            //{
            //    entity.Property(e => e.Profit)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Report>(entity =>
            //{
            //    entity.Property(e => e.SellingPrice)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Stock>(entity =>
            //{
            //    entity.Property(e => e.PriceOfPerItem)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});


            //modelBuilder.Entity<Stock>(entity =>
            //{
            //    entity.Property(e => e.TotalPriceOfAllItems)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<Stock>(entity =>
            //{
            //    entity.Property(e => e.TotalPriceOfPerItem)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<MarketValue>(entity =>
            //{
            //    entity.Property(e => e.TotalProfit)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<MarketValue>(entity =>
            //{
            //    entity.Property(e => e.CashInHand)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});

            //modelBuilder.Entity<CustomerLimits>(entity =>
            //{
            //    entity.Property(e => e.SpentPrice)
            //        .HasColumnType("decimal(6,2)"); // Example precision and scale (adjust as needed)
            //                                        // Configure other properties similarly if necessary
            //});
            //base.OnModelCreating(modelBuilder);
        }
    }
}

