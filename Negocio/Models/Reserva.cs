using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime DataReserva { get; set; }
        public int ClienteId { get; set; }
    }
}
