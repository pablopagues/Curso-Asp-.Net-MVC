using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Aluguel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int CarroId { get; set; }
        public DateTime DataTransacao { get; set; }
        public DateTime DataReserva { get; set; }
        public Boolean Efetivado { get; set; }
    }
}
