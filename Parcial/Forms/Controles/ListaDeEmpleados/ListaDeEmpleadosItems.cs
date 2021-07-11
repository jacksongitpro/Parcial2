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

namespace Parcial.Forms.Controles.ListaDeEmpleados
{
    public partial class ListaDeEmpleadosItems : UserControl
    {
        //Tenemos el empleado.
        public Empleado Empleado;
        public ListaDeEmpleadosItems()
        {
            InitializeComponent();
        }
        //Creamos un constructor con parametro
        public ListaDeEmpleadosItems(Empleado empleado)
        {
            InitializeComponent();
            Verbutton.Click += VerButton_Click;
            SetPersona(empleado);
            
        }
        void SetPersona(Empleado empleado)
        {
            //Seteamos la persona que tenemos almacenada.
            Empleado = empleado;
            //Actualizamos el label con la info necesaria.
            //nombreApellidoLabel.Text = $"{empleado.Nombre}";
        }
        private void ListaDeEmpleadosItems_Load(object sender, EventArgs e)
        {

        }

        private void nombreApellidoLabel_Click(object sender, EventArgs e)
        {

        }
        private void VerButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            DetalleEmpleadoForm formEmpleado = new DetalleEmpleadoForm(Empleado);
            formEmpleado.ShowDialog();

        }

        private void Nombrelabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
