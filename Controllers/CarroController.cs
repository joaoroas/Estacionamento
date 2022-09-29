using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Retirar()
        {
            return View();
        }
    }
}
