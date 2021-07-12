using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Forms;
using Parcial.Forms.Controles.ListaDeEmpleados;
using Parcial.Modelo;

namespace Parcial
{
    public partial class MenuPrincipal : Form
    {
        List<Empleado> Empleados;
        List<Usuario> Usuarios;

        public MenuPrincipal()
        {      
                 
            InitializeComponent();
            Empleados = BaseDeDatos.Empleados;           

        }

        private void buttonpersonal_Click(object sender, EventArgs e)
        {
            GestionPersonalForm personalform = new GestionPersonalForm();
            personalform.ShowDialog();
           
            //personal1.Show();

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Especialidades_Click(object sender, EventArgs e)
        {
            GestionMaterial GM = new GestionMaterial();
            GM.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MiCuenta FormCuenta = new MiCuenta();
            FormCuenta.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Ingreso Form = new Ingreso();
            Form.ShowDialog();
            
        }

        public void label4_Click(object sender, EventArgs e)
        {
            Usuario user = Usuarios.Find((Usuario admin) => admin.nombre == label4.Text);
            label4.Text = user.nombre;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            //this.Hide();
            GestionEspecialidadesForm EspecialidadesForm = new GestionEspecialidadesForm();
            EspecialidadesForm.ShowDialog();
        }
    }
}
