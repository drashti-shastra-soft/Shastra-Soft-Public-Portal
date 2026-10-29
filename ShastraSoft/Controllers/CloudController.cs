using Microsoft.AspNetCore.Mvc;

namespace ShastraSoft.Controllers
{
    public class CloudController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
