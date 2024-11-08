using Microsoft.AspNetCore.Mvc;
using TravelManagementAPI.Models;

namespace TravelManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TravelController : Controller
{
    public async Task<IActionResult<IEnumerable<Travel>>> Index()
    {
        
    }
}
