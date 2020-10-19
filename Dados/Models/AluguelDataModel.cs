using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
    public class AluguelDataModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int CarroId { get; set; }
        public DateTime DataTransacao { get; set; }       
        public Boolean Efetivado { get; set; }

    }
}
