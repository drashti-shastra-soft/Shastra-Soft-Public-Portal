using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class DigitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
