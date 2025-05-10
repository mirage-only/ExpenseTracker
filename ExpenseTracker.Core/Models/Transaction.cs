using ExpenseTracker.Core.Enums;

namespace ExpenseTracker.Core.Models;

public class Transaction
{
    public uint Id { get; set; }
    
    public User User { get; set; }
    
    public uint UserId { get; set; }
    
    public Category Category { get; set; }
    
    public uint CategoryId { get; set; }
    
    public string Description { get; set; }
    
    public decimal Amount { get; set; }
    
    public TypeEnum Type { get; set; }
    
    public DateTime CreatedAt { get; set; }
}