using Microsoft.AspNetCore.Mvc;

namespace TravelManagementAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TravelController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
