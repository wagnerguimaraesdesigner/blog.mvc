using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogBea.Models;

namespace BlogBea.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Categoria> categorias;
    private List<Postagem> postagens;

    public HomeController(ILogger<HomeController> logger)
    { 
        _logger = logger;
        Categoria tecnologia = new ();
        tecnologia.Id = 1;
        tecnologia.Nome = "Tegnologia";
        Categoria categoria2 =  new(){
            Id= 2,
            Nome = "Receitas"
        };

        Categoria receita = new(3, "Receitas");
        postagens =[
            new(){
                Id = 1,
                Nome = "Receita Morango do Amor",
                CategoriaId = 2,
                Categoria = categoria2,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Morango do Amor é simples, deliciosa e perfeita para festas ou para aquele lanche especial",
                Texto = "deliciosa receita",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },

              new(){
                Id = 2,
                Nome = "Torta de Morango",
                CategoriaId = 3,
                Categoria = receita,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "",
                Texto = "testeeee",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/torta de morango.jpg"

            },

                 new(){
                Id = 3,
                Nome = "Receita Morango do Amor 3",
                CategoriaId = 4,
                Categoria = receita,
                DataPostagem = DateTime.Parse("08/08/2025"),
                Descricao = "Ver mais...",
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
                Descricao = "Ver mais...",
                Texto = "testeeee",
                Thumbnail = "/img/1.jpeg",
                Foto = "/img/1.jpeg"

            },
        ];


    }

    public IActionResult Index()
    {


        
        return View(postagens);
    }

      public IActionResult Postagem (int id)
    {
        var postagem = postagens
            .Where(p => p.Id == id)
            .SingleOrDefault();
        if (postagem == null)
            return NotFound();
        return View(postagem);
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


