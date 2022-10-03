using Estacionamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Estacionamento.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<CarroModel> Carros { get; set; }
    }
}
