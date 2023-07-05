using Microsoft.AspNetCore.Mvc;

namespace Asp.NetCoreMiniProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Asp.NetCoreMiniProject.Models.Request model = new Models.Request();
            model.name = "ceylan";
            model.phone = "55555555555";
            model.email = "ceylan@gmail.com";
            model.message = "merhaba nasılsın";
            return View(model);
        }
    }
}
