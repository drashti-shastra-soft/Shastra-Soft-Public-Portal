using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using ShastraSoft.Models;
using Newtonsoft.Json;

namespace ShastraSoft.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly ILogger<HomeController> _logger;
        private readonly IFileReaderService _fileReaderService;
        private readonly IEmailSenderService _emailSenderService;

        public HomeController(ILogger<HomeController> logger, IConfiguration config, IFileReaderService fileReaderService, IEmailSenderService emailSenderService)
        {
            _logger = logger;
            _config = config;
            _fileReaderService = fileReaderService;
            _emailSenderService = emailSenderService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var mContact = new Contact();
            return View(mContact);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public async Task<IActionResult> Index(Contact mContact)
        {
            try
            {
                string content = _fileReaderService.ReadFileContent("\\EmailTemplate\\ContactUs.html");
                content = content.Replace("{{Name}}", mContact.Name);
                content = content.Replace("{{Email}}", mContact.Email);
                content = content.Replace("{{Subject}}", mContact.Subject);
                content = content.Replace("{{Message}}", mContact.Message);

                await _emailSenderService.SendEmailAsync("Contact Form", content, _config["AdminSettings:Email"] ?? string.Empty);
                ViewBag.NotificationType = "success";
                ViewBag.NotificationMsg = "Your details have been saved. Our team will contact you soon!";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Contact Form");
                ViewBag.NotificationType = "error";
                ViewBag.NotificationMsg = "Something went wrong!";
            }
            return View("Index", mContact);
        }
    }
}
