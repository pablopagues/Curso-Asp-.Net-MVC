using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
    public class CarroDataModel
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
