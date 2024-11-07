using TravelManagementAPI.Context;
using TravelManagementAPI.Models;

namespace TravelManagementAPI.Repository;

public class TravelRepository : Repository<Travel>, ITravelRepository
{
    public TravelRepository(AppDbContext context) : base(context)
    {
    }
}
