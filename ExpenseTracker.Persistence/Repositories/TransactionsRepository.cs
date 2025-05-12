using ExpenseTracker.Core.Interfaces.Repositories;
using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Persistence.Repositories;

public class TransactionsRepository(ApplicationDbContext dbContext) : ITransactionsRepository
{
    public async Task<List<Transaction>> GetAllTransactionsOfUser(uint userId)
    {
        return await dbContext.Transactions
            .Where(transaction => transaction.UserId == userId)
            .ToListAsync();
    }

    public async Task<uint> AddTransaction(Transaction transaction)
    {
        var addedTransaction = await dbContext.Transactions
            .AddAsync(transaction);
        
        await dbContext.SaveChangesAsync();
        
        return addedTransaction.Entity.Id;
    }

    public async Task DeleteTransaction(Transaction transaction)
    {
        dbContext.Remove(transaction);
        
        await dbContext.SaveChangesAsync();
    }
}