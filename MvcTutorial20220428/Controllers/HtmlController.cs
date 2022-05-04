using Microsoft.AspNetCore.Mvc;

namespace MvcTutorial20220428.Controllers
{
    public class HtmlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CssDemo()
        {
            return View();
        }
    }
}
