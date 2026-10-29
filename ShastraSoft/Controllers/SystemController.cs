using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
