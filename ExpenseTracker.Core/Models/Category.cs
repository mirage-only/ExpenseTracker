using ExpenseTracker.Core.Enums;

namespace ExpenseTracker.Core.Models;

public class Category
{
    public uint Id { get; set; }
    
    public string Name { get; set; }
    
    public TypeEnum Type { get; set; }
}