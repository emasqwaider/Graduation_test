using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.DataBase;
using WebApplication5.Models;

namespace WebApplication5.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ApplicationDbContext _db;


    public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
    {
        _db = db;
        _logger = logger;
    }

    public IActionResult Index()
    {
        IEnumerable<Student> Student = _db.Student.ToList();
        return View(Student);
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
