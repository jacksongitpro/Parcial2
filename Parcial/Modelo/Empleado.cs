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
        public string Dni { get; set; }
        public string Matricula { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Calle { get; set; }
        public String Localidad { get; set; }
        public String Provincia { get; set; }
        public Especialidad Especialidad { get; set; } //= new Especialidad();
        public String Descripcion { get; set; }

    }
}
