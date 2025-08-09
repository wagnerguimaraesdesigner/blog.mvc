using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogBea.Models;

namespace BlogBea.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    { 
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Mensagem"] = "Oi mundo!";
        Categoria categoria = new ();
        categoria.Id = 1;
        categoria.Nome = "Tegnologia";
        Categoria categoria2 =  new(){
            Id= 2,
            Nome = "IA"
        };

        List<Postagem> postagens =[
            new(){
                Id = 1,
                Nome = "Saiu o ChatGpt 5",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dfçlkgjmçldfg",
                Texto = "kgklfghlkfghj"

            }
        ];


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


