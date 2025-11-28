using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_Especial.clases
{
    internal class Consulta
    {
        public int IdConsulta { get; set; }
        public int IdPaciente { get; set; }
        public int IdPersonal { get; set; }
        public DateTime FechaConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string Procedimiento { get; set; }

        public Paciente Paciente { get; set; }
        public Personal Personal { get; set; }
    }
}
