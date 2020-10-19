using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Models
{
    public class ReservaDataModel
    {
        public int Id { get; set; }
        public DateTime DataReserva { get; set; }
        public int ClienteId { get; set; }
    }
}
