using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserAuthentication.Application.Commands;
using UserAuthentication.Presentation.Models;

namespace UserAuthentication.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISender _sender;

        public HomeController(ILogger<HomeController> logger , ISender sender)
        {
            _logger = logger;
            _sender = sender;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("/SingUp")]
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        [Route("/SingUp")]
        public async Task<IActionResult> SingUp(CreateUserCommand command)
        {
            await _sender.Send(command);
            return View();
        }

        [Route("/SingIn")]
        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        [Route("/SingIn")]
        public async Task<IActionResult> SingIn(LoginUserCommand command)
        {
             await _sender.Send(command);
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}