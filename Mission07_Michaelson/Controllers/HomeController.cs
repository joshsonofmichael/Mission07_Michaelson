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
        ViewBag.Categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
        return View("MovieNewEdit");
    }
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie); // add record to database
        _context.SaveChanges();
        return View("Success", movie);
    }
    public IActionResult ViewCollection()
    {
        var movies = _context.Movies
        .OrderBy(m => m.Title)
        .ToList();
        ViewBag.Categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
        return View(movies);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var Movie = _context.Movies.Single(m => m.MovieId == id);
        ViewBag.Categories = _context.Categories.OrderBy(c => c.CategoryName).ToList();
        return View("MovieNewEdit", Movie);
    }
    [HttpPost]
    public IActionResult Edit(Movie movie)
    {
        _context.Update(movie);
        _context.SaveChanges();
        return RedirectToAction("ViewCollection");
    }

    public IActionResult ConfirmDelete(int id)
    {
        var movie = _context.Movies.Single(m => m.MovieId == id);
        return View("Delete", movie);
    }
    public IActionResult Delete(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        return RedirectToAction("ViewCollection");
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
