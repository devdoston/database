using Microsoft.EntityFrameworkCore;
using databases.Entities;

namespace databases.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
    : base (options) {}

    public DbSet<Movie>? Movies { get; set; }
}