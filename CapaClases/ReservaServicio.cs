using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class ReservaServicio
    {
        public int Reserva { get; set; }
        public int Servicio { get; set; }
        public SqlDateTime Fecha { get; set; }
    }
}
