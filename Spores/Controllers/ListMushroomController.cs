using Microsoft.AspNetCore.Mvc;

namespace Spores.Controllers
{
    public class ListMushroomController : Controller
    {
        public IActionResult ListMushroom()
        {
            return View();
        }
    }
}
