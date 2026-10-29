using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class DesignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
