using Parcial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial.Forms
{
    public partial class CrearMaterial : Form
    {
        //Departamento Departamento;


        //GAW: Crear constructor con parametro departamento.
        public CrearMaterial()
        {
            InitializeComponent();
            guardarButton.Click += GuardarButton_Click;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Creo la nueva persona usando los valores provistos
            //En la vida real, hay que validarlos antes de hacer esto.

            Material mat = new Material()
            {
                Nombre = nombreTextBox.Text,
                Cantidad = (int)cantidadNumericUpDown.Value
            };

            // BaseDeDatos.Materiales.Add(mat);
            //Departamento.Materiales.Add();

            Close();
        }
    }
}
