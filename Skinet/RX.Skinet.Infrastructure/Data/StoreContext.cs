using Microsoft.EntityFrameworkCore;
using RX.Skinet.Core.Entities;

namespace RX.Skinet.Infrastructure.Data;

public class StoreContext(DbContextOptions<StoreContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}