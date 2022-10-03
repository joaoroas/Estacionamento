using Estacionamento.Data;
using Estacionamento.Models;
using Estacionamento.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Estacionamento.Controllers
{
    public class CarroController : Controller
    {
        private readonly ICarroRepository _carroRepository;

        public CarroController(ICarroRepository carroRepository)
        {
            _carroRepository = carroRepository;
        }

        public IActionResult Index()
        {
          List<CarroModel> carros = _carroRepository.BuscarTodos();

            return View(carros);
        }
        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Retirar(int id)
        {
           CarroModel carro = _carroRepository.ListaPorId(id);

            return View(carro);
        }
        [HttpPost]
        public IActionResult Criar(CarroModel carro)
        {
            _carroRepository.Adicionar(carro);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(CarroModel carro, int id)
        {
            _carroRepository.AddHoras(carro);

            CarroModel carroBd = _carroRepository.ListaPorId(id);

            return View(carroBd);

        }

        public IActionResult Apagar(int id)
        {
            _carroRepository.Apagar(id);
            return RedirectToAction("Index");
        }
    }
}
