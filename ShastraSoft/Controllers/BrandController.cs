using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
