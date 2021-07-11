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
using Parcial.Forms;

namespace Parcial.Forms
{
    public partial class DetalleEmpleadoForm : Form
    {
        Empleado Empleado;
        public DetalleEmpleadoForm()
        {
            InitializeComponent();
        }
        //Creamos el constructor que recibe el parametro
        public DetalleEmpleadoForm(Empleado empleado)
        {
            InitializeComponent();
            SetEmpleado(empleado);

        }

        //La logica de seteo de persona.
        void SetEmpleado(Empleado p)
        {
            //seteamos la persona.
            Empleado = p;

            //Actualizamos los labels.
            this.Nombreinf_label4.Text = Empleado.Nombre;            
            this.Dniinf_label5.Text = $"{Empleado.Dni}";
           
        }

        private void DetalleEmpleadoForm_Load(object sender, EventArgs e)
        {

        }

        private void DetalleEmpleadoForm_Load_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
