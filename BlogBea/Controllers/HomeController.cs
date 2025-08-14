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
        Categoria tecnologia = new ();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tegnologia";
        Categoria categoria2 =  new(){
            Id= 2,
            Nome = "IA"
        };

        Categoria receita = new(3, "Morango do amor");

        List<Postagem> postagens =[
            new(){
                Id = 1,
                Nome = "Receita Morango do Amor",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "dfçlkgjmçldfg",
                Texto = "kgklfghlkfghj",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },

              new(){
                Id = 2,
                Nome = "Receita Morango do Amor 2",
                CategoriaId = 3,
                Categoria = receita,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "teste",
                Texto = "testeeee",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },

                 new(){
                Id = 3,
                Nome = "Receita Morango do Amor 3",
                CategoriaId = 4,
                Categoria = receita,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "teste",
                Texto = "testeeee",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },
                 new(){
                Id = 4,
                Nome = "Receita Morango do Amor 4",
                CategoriaId = 5,
                Categoria = receita,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "teste",
                Texto = "testeeee",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },
        ];


        return View(postagens);
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


