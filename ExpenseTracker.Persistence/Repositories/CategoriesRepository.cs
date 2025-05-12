using ExpenseTracker.Core.Interfaces.Repositories;
using ExpenseTracker.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Persistence.Repositories;

public class CategoriesRepository(ApplicationDbContext dbContext) : ICategoriesRepository
{
    public async Task<List<Category>> GetAllCategories()
    {
        return await dbContext.Categories
            .AsNoTracking()
            .OrderBy(category => category.Name)
            .ToListAsync();
    }
}