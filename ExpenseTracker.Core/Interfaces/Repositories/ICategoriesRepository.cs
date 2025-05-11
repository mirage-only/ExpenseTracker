using ExpenseTracker.Core.Models;

namespace ExpenseTracker.Core.Interfaces.Repositories;

public interface ICategoriesRepository
{
    public Task<List<Category>> GetAllCategories();
    
    //public Task<uint> AddCategory(Category category);
    
    //public Task DeleteCategory(uint categoryId)
}