using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class DesktopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
