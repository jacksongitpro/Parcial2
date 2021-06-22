using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Departamento
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public List<Material> Materiales { get; set; } = new List<Material>();
    }
}
