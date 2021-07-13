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
    public partial class AltaEmpleadoForm : Form
    {
        public AltaEmpleadoForm()
        {
            InitializeComponent();
            guardarButton.Click += GuardarButton_Click;
            comboBoxEspecialidad.DataSource = BaseDeDatos.Especialidades;
            comboBoxEspecialidad.DisplayMember = "Nombre";
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            //Creo el empleado usando los valores provistos
            //En la vida real, hay que validarlos antes de hacer esto.            
            Empleado empleado = new Empleado()
            {
                Nombre = NombretextBox.Text,
                Dni = DnitexBox.Text,
                Matricula = textBoxMatricula.Text,
                Telefono = textBoxTelefono.Text,
                Email = textBoxEmail.Text,
                Calle = CalletextBox.Text,
                Localidad = labelLocalidad.Text,
                Provincia = labelPovincia.Text,
                Especialidad = (Especialidad)comboBoxEspecialidad.SelectedItem

                //labeldescriptiva.Text = comboBoxEspecialidad.DisplayMember = "Descripcion";

            };
            BaseDeDatos.Empleados.Add(empleado);
            Close();

        }
        private void comboEspecialidades_SelectedValueChanged(object sender, EventArgs e)
        {
            Especialidad p = (Especialidad)comboBoxEspecialidad.SelectedItem;
            labeldescriptiva.Text = $"{p.Descripcion}";
        }
        private void labelContacto_Click(object sender, EventArgs e)
        {

        }
        private void DnitexBox_TextChanged(object sender, EventArgs e)
        {
            //if (BaseDeDatos.Empleados.Find((Empleado x) => x.Dni == empleado.Dni) == null;
            //    {
            //    BaseDeDatos.Empleados.Add(x);
            //}
            //else MessageBox.Show("El Empleado Ya existe");

            //Empleado empleado = BaseDeDatos.Empleados.Find((Empleado emp) => emp.Dni != DnitexBox.Text);
            //if (empleado.Dni == DnitexBox.Text)
            //{
            //    MessageBox.Show("El Empleado Ya existe");
            //    DnitexBox.Clear();
            //    DnitexBox.Focus();
            //}
        }

        private void guardarButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
