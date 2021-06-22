using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public int Matricula { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }
        public string Especialidad { get; set; }
        public string Descripcion { get; set; }

    }
}
