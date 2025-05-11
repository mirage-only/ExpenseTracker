using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Persistence.Configurations;

public class TransactionsConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder
            .HasKey(transaction => transaction.Id);

        builder
            .Property(transaction => transaction.Id)
            .ValueGeneratedOnAdd();

        builder
            .HasOne(transaction => transaction.User)
            .WithMany(user => user.Transactions);

        builder
            .HasOne(transaction => transaction.Category)
            .WithMany();
    }
}