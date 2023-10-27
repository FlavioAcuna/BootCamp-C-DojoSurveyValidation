using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurvey.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("index");
    }

    public IActionResult Privacy()
    {
        return View();
    }


    [HttpPost("ProcesarDatos")]
    public IActionResult NewStudent(Survey newStudent)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine("Paso la validacion ");
            return View("SubmittedForm", newStudent);
        }
        else
        {
            Console.WriteLine("no Paso la validacion ");
            return View("index");
        }

    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
