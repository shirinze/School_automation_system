using Microsoft.AspNetCore.Mvc;

namespace OBYS.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
