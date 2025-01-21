using Microsoft.AspNetCore.Mvc;

namespace fs_mvc.Controllers;

public class FruitController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Apple()
    {
        return View();
    }
    public IActionResult Banana()
    {
        return View();
    } 
}


   

