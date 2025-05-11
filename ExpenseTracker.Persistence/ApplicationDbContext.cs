using ExpenseTracker.Core.Models;
using ExpenseTracker.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Persistence;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    
    public DbSet<Transaction> Transactions { get; set; }
    
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        
        modelBuilder.ApplyConfiguration(new TransactionsConfiguration());
        
        modelBuilder.ApplyConfiguration(new СategoriesConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}