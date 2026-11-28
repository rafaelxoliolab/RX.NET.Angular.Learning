using System;
using Microsoft.EntityFrameworkCore;

namespace RX.DatingApp.Api.Data;

public class AppDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Entities.AppUser> Users { get; set; }
}
