using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces.Repositories;

public interface ITransactionsRepository
{
    public Task<List<Transaction>> GetTransactionsOfUser(uint userId);
    
    public Task<uint> AddTransaction(Transaction transaction);
    
    public Task DeleteTransaction(uint transactionId);
}