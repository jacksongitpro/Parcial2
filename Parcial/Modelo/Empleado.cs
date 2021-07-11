using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Modelo
{
    public class Empleado
    {
        public String Nombre { get; set; }
        public int Dni { get; set; }
        public int Matricula { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public String Localidad { get; set; }
        public String Provincia { get; set; }
        public Especialidades Especialidad { get; set; } = new Especialidades();
        public String Descripcion { get; set; }

    }
}
