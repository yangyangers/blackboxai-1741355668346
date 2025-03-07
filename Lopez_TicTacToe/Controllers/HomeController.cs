using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VillaVista.Models;

namespace VillaVista.Controllers;

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

    public IActionResult Announcement()
    {
        return View();
    }

    public IActionResult Community()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Facilities()
    {
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }

    public IActionResult VirtualTour()
    {
        _logger.LogInformation("Virtual Tour page accessed");
        return View();
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
}
