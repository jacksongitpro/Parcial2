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
    public partial class AltaEspecialidadesForm : Form
    {

        public AltaEspecialidadesForm()
        {
            InitializeComponent();
            //GuardarBtn.Click += GuardarBtn_Click;
            //Close();
        }
        public AltaEspecialidadesForm(Especialidad especialidad)
        {
            InitializeComponent();
            GuardarBtn.Click += GuardarBtn_Click;
           
        }


        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad()
            {
                Descripcion = DescripcionTextBox.Text,
                Nombre = NombreTextBox.Text
            };
            BaseDeDatos.Especialidades.Add(especialidad);
            Close();
        }
    }
}
