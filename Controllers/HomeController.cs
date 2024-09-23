using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FanurApp.Models;
using Microsoft.AspNetCore.Localization;
using FanurApp.ViewModels;
using Telegram.Bot;

namespace FanurApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration configuration;

    public HomeController(ILogger<HomeController> logger, IConfiguration _configuration)
    {
        _logger = logger;
        configuration = _configuration;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
        return View();
    }
    public IActionResult ContactUs()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ContactUsAsync(ContactUsVM viewModel)
    {
        if (ModelState.IsValid)
        {
            try
            {
                string token = configuration.GetValue<string>("Telegram:Token");
                string adminId = configuration.GetValue<string>("Telegram:AdminId");

                var bot = new TelegramBotClient(token);
                string message = $"🙋‍♂️ Sender: <b>{viewModel.ContactName}</b> \n" +
                 $"📱 Contact number: <b>{viewModel.ContactPhone}</b> \n" +
                 $"📧 Message subject: <b>{viewModel.Subject}</b> \n" +
                 $"📝 Message content: <b>{viewModel.Message}</b>";

                await bot.SendTextMessageAsync(adminId, message, parseMode: Telegram.Bot.Types.Enums.ParseMode.Html);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Index", "Home", null);
        }
        return View(viewModel);
    }
    public IActionResult FirstProject()
    {
        return View();
    }
    public IActionResult SecondProject()
    {
        return View();
    }
    public IActionResult ThirdProject()
    {
        return View();
    }
    public IActionResult FourthProject()
    {
        return View();
    }
    public IActionResult FifeProject()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SetLanguage(string culture, string returnUrl)
    {
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        );

        return LocalRedirect(returnUrl);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
