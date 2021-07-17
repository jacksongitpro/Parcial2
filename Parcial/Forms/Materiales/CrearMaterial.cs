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


namespace Parcial.Forms
{
    public partial class CrearMaterial : Form
    {
        
        public CrearMaterial()
        {
            InitializeComponent();

           
        }
        public CrearMaterial(Material mat)
        {
            InitializeComponent();
            guardarButton.Click += guardarButton_Click_1;
        }
      

        private void guardarButton_Click_1(object sender, EventArgs e)
        {
            Material mat = new Material()
            {
                Nombre = nombreTextBox.Text,
                Cantidad = (int)cantidadNumericUpDown.Value
            };
            BaseDeDatos.Materiales.Add(mat);
            Close();

        }
    }
}
