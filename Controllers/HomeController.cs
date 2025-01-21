using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using fs_mvc.Models;

namespace fs_mvc.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }
    public IActionResult SuperHeroes()
    {
        ViewBag.PageTitle = "SuperHeroes";
        ViewBag.Universe1 = "DC";
        ViewBag.Universe2 = "Marvel";

        List<string> dcCharacters = new List<string>();
        dcCharacters.Add("Batman");
        dcCharacters.Add("Superman");
        dcCharacters.Add("Hulk");
        ViewBag.DC = dcCharacters;
        ViewBag.MV1 = "Spiderman"; 
        ViewBag.MV2 = "Venom";
        
        return View();
    }
    public IActionResult Planets()
    {
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}