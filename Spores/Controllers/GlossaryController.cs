using Microsoft.AspNetCore.Mvc;

namespace Spores.Controllers
{
    public class GlossaryController : Controller
    {
        public IActionResult Glossary()
        {
            return View();
        }
    }
}
