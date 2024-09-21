using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FanurApp.Models;
using Microsoft.AspNetCore.Localization;

namespace FanurApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
