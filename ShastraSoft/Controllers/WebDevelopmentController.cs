using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class WebDevelopmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
