using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaClases
{
    public class TipoTemporada
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Coeficiente { get; set; }
    }
}
