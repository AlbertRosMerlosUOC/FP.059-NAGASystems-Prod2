using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class Disponibilidad
    {
        public int Id { get; set; }
        public int Habitacion { get; set; }
        public SqlDateTime Fecha { get; set; }
    }
}
