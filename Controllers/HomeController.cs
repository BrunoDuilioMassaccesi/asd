using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using login.Models;

namespace login.Controllers;

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
        public IActionResult FormularioPreguntas()
    {
        return View();
    }
    public IActionResult FormularioPreguntas2()
    {
            return View();
    }
    public IActionResult FormularioPreguntas3()
    {
            return View();
    }
        public IActionResult Terminado()
    {
            return View();
    }
            public IActionResult Felicidades()
    {
            return View();
    }

}
