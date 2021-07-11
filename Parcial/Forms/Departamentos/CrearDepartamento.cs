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

namespace Parcial
{
    public partial class CrearDepartamento : Form
    {
        public CrearDepartamento()
        {
            InitializeComponent();
            guardarButton.Click += GuardarButton_Click;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Creo la nueva persona usando los valores provistos
            //En la vida real, hay que validarlos antes de hacer esto.

            Departamento dep = new Departamento()
            {
                Nombre = nombreTextBox.Text,
                Direccion = direccionTextBox.Text
            };

            BaseDeDatos.Departamentos.Add(dep);

            Close();
        }

        private void CrearDepartamento_Load(object sender, EventArgs e)
        {

        }
    }
}