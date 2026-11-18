using Microsoft.AspNetCore.Mvc;

namespace OficialEF.Controllers; //Onde está o arquivo 



public class ProdutosController : Controller
{
    // Agora temos as ações, como iremos acessar uma pagina
    public IActionResult Index()
    {
        return Content("Catálogo de Produtos");
    }
}