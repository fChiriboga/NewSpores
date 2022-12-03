using Microsoft.AspNetCore.Mvc;

namespace Spores.Controllers
{
    public class AnatomyController : Controller
    {
        public IActionResult Anatomy()
        {
            return View();
        }
    }
}
