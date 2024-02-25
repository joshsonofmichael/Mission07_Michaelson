using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission07_Michaelson.Models;

namespace Mission07_Michaelson.Controllers;

public class HomeController : Controller
{

    private MovieCollectionContext _context; // set up instance of database
    public HomeController(MovieCollectionContext temp) 
    {
        _context = temp; // assign instance to the current database
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutJoel()
    {
        return View();
    }
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie); // add record to database
        _context.SaveChanges();
        return View("Success", movie);
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
