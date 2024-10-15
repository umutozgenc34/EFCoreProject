

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace EFCore.CodeFirst.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    //public DbSet<Student> Students { get; set; }
    //public DbSet<Teacher> Teachers { get; set; }
    public DbSet<ProductFeature> ProductFeatures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Initializer.Build();
        optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information).UseLazyLoadingProxies().UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //onetomany
        //modelBuilder.Entity<Category>().HasMany(x=> x.Products).WithOne(x => x.Category).HasForeignKey(x=> x.CategoryId);
        //onetoone
        //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x=> x.ProductId);
        //manytomany
        //modelBuilder.Entity<Student>().HasMany(x => x.Teachers).WithMany(x => x.Students).
        //UsingEntity<Dictionary<string, object>>(
        //"StudentTeacher",
        //x => x.HasOne<Teacher>().WithMany().HasForeignKey("TeacherId").HasConstraintName("FK_TeacherId"),
        //x => x.HasOne<Student>().WithMany().HasForeignKey("StudentId").HasConstraintName("FK_StudentId")
        //);
          
        //base.OnModelCreating(modelBuilder);
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
