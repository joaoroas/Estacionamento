using Estacionamento.Models;

namespace Estacionamento.Repository
{
    public interface ICarroRepository
    {
        CarroModel ListaPorId(int id);
        List<CarroModel> BuscarTodos();
        CarroModel Adicionar(CarroModel carro);
        bool Apagar(int id);

    }
}
