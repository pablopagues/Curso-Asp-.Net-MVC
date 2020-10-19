using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Cor { get; set; }
        public string Foto { get; set; }
        public int CategoriaCarroId { get; set; }
    }
}
