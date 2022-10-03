using Estacionamento.Data;
using Estacionamento.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Estacionamento.Repository
{
    public class CarroRepository : ICarroRepository
    {
        private readonly Context _context;
        public CarroRepository(Context context)
        {
            this._context = context;
        }
        public CarroModel Adicionar(CarroModel carro)
        {
            _context.Carros.Add(carro);
            _context.SaveChanges();

            return carro;
        }

        public bool Apagar(int id)
        {
            CarroModel carro = ListaPorId(id);

            _context.Carros.Remove(carro);
            _context.SaveChanges();

            return true;
            
        }

        public List<CarroModel> BuscarTodos()
        {
            return _context.Carros.ToList();
        }

        public CarroModel ListaPorId(int id)
        {
            return _context.Carros.FirstOrDefault(x => x.Id == id);
        }

        
    }
}
