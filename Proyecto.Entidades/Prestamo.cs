using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Entidades
{
    public class Prestamo
    {
        public int IdLibro { get; set; }
        public int IdPersona { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

    }
}
