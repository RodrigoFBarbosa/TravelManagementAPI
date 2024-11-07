using TravelManagementAPI.Models;

namespace TravelManagementAPI.Repository;

public interface IExpenseRepository : IRepository<Expense>
{
    Task<IEnumerable<Expense>> GetExpensesByTravelIdAsync(int travelId);
}
