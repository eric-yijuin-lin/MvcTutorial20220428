using Microsoft.AspNetCore.Mvc;
using MVC_Tutorial_05.Models;
using MvcTutorial20220428.Models;
using System.Diagnostics;

namespace MvcTutorial20220428.Controllers
{
    public class JQueryController : Controller
    {
        public IActionResult jQuery()
        {
            return View();
        }

        public async Task<IActionResult> GetDummySelectList()
        {
            await Task.Delay(3000);
            return Json(new List<DemoListItem>()
            {
                new DemoListItem() { Name = "選項 1", Value = "value 1" },
                new DemoListItem() { Name = "選項 2", Value = "value 2" },
                new DemoListItem() { Name = "選項 3", Value = "value 3" },
            });
        }
    }
}