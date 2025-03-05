using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniCRM.Domain.Models;

namespace MiniCRM.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ProductOrder> ProductOrders { get; set; }
    public DbSet<ProductOrderItem> ProductOrderItems { get; set; }
    public DbSet<ServiceOrder> ServiceOrders { get; set; }
    public DbSet<EntityChangeHistory> EntityChangeHistories { get; set; }
    public DbSet<Discount> Discounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=service_center.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductOrder>()
            .HasMany(po => po.Items)
            .WithOne(poi => poi.ProductOrder)
            .HasForeignKey(poi => poi.ProductOrderId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ProductOrderItem>()
            .HasOne(poi => poi.Product)
            .WithMany(p => p.OrderItems)
            .HasForeignKey(poi => poi.ProductId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ServiceOrder>()
            .HasOne(so => so.Service)
            .WithMany(s => s.ServiceOrders)
            .HasForeignKey(so => so.ServiceId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ServiceOrder>()
            .HasOne(so => so.Employee)
            .WithMany(u => u.ServiceOrders)
            .HasForeignKey(so => so.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("Строка подключения не найдена в конфигурации.");
        }

        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite(connectionString);
        });

        return services;
    }
}