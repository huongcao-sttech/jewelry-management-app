using Abp.Zero.EntityFrameworkCore;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using MyProject.Products;

namespace MyProject.EntityFrameworkCore;

public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
{
    /* Define a DbSet for each entity of the application */
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }

    public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
        : base(options)
    {
    }
}
