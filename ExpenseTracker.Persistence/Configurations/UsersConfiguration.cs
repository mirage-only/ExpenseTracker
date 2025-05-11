using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Persistence.Configurations;

public class UsersConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(user => user.Id);

        builder
            .Property(user => user.Id)
            .ValueGeneratedOnAdd();
        
        builder
            .HasIndex(user => user.Email)
            .IsUnique();

        builder
            .HasMany(user => user.Transactions)
            .WithOne(transaction => transaction.User)
            .HasForeignKey(transaction => transaction.UserId);
    }
}