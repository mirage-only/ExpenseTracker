using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces.Repositories;

public interface ITransactionsRepository
{
    public Task<List<Transaction>> GetAllTransactionsOfUser(uint userId);
    
    public Task<uint> AddTransaction(Transaction transaction);
    
    public Task DeleteTransaction(Transaction transaction);
}