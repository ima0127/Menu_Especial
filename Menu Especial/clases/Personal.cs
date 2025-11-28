using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Especial.clases
{
    internal class Personal
    {
        public int IdPersonal { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }

        // Relación con Puesto
        public int IdPuesto { get; set; }
        public Puesto Puesto { get; set; }

    }
}
