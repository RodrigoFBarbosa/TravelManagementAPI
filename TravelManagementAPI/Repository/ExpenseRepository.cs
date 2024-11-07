using Microsoft.EntityFrameworkCore;
using TravelManagementAPI.Context;
using TravelManagementAPI.Models;

namespace TravelManagementAPI.Repository;

public class ExpenseRepository : Repository<Expense>, IExpenseRepository
{
    public ExpenseRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Expense>> GetExpensesByTravelIdAsync(int travelId)
    {
        return await _context.Expenses.Where(e => e.TravelId == travelId).ToListAsync();
    }
}
