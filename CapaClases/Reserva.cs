using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Reserva
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public int Habitacion { get; set; }
        public int TipoAlojamiento { get; set; }
        public int TipoTemporada { get; set; }
        public SqlDateTime FechaInicio { get; set; }
        public SqlDateTime FechaFin { get; set; }
        public decimal Factura { get; set; }
        public string Referido { get; set; }
        public Boolean CheckIn { get; set; }
        public Boolean Cancelado { get; set; }
        public int Oferta { get; set; }
    }
}
