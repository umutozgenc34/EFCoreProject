

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Category>().HasMany(x=> x.Products).WithOne(x => x.Category).HasForeignKey(x=> x.CategoryId);
    }


    //public override int SaveChanges()
    //{
    //    ChangeTracker.Entries().ToList().ForEach(e =>
    //    {
    //        if (e.Entity is Product p)
    //        {
    //            if (e.State == EntityState.Added)
    //            {
    //                p.CreatedDate = DateTime.Now;
    //            }
    //        }
    //    }

    //    );

    //    return base.SaveChanges();
    //}
}
