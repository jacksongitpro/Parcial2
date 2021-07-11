using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Modelo;

namespace Parcial.Forms.Controles.ListaDeEspecialidades
{
    public partial class ListaDeEspecialidadesItems : UserControl
    {
      
        public Especialidad Especialidad;

        public ListaDeEspecialidadesItems()
        {
            InitializeComponent();
        }

        public ListaDeEspecialidadesItems(Especialidad especialidad)
        {
            InitializeComponent();
        }
       
       
      

        private void Nombrelabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NombreApellidoLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void Descripcionlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
