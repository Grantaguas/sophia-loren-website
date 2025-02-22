using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sophia.Models;

namespace Sophia.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
        {
            return View();
        }

    public IActionResult Movies(){
        return View();
    }

     public IActionResult Books(){
        return View();
    }

     public IActionResult Fan(){
        return View();
    }

     public IActionResult Contact(){
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
