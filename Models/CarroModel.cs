﻿namespace Estacionamento.Models
{
    public class CarroModel
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public decimal PrecoInicial { get; set; }
        public decimal PrecoHora { get; set; }
    }
}
