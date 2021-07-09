using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class MenuPrincipal : Form
    {
        List<Empleado> Empleados;
        List<Usuario> Usuarios;


        public MenuPrincipal()
        {        
                  
            InitializeComponent();
            Empleados = BaseDeDatos.ListaEmpleados;
            

        }


        private void buttonpersonal_Click(object sender, EventArgs e)
        {
         
          
            Empleado emp2 = new Empleado();
            emp2.Nombre = "Gaston Robles";
            emp2.Dni = 33561867;
            emp2.Matricula = 876321;
            Empleado emp1 = new Empleado();
            emp1.Nombre = "Fernando Galvez";
            emp1.Dni = 38401865;
            emp1.Matricula = 123321;
            Empleado emp3 = new Empleado();
            emp3.Nombre = "Martin Peralta";
            emp3.Dni = 35401266;
            emp3.Matricula = 423351;
            Empleado emp4 = new Empleado();
            emp4.Nombre = "Ruben caré";
            emp4.Dni = 37653865;
            emp4.Matricula = 999342;
            Empleado emp5 = new Empleado();
            emp5.Nombre = "Nicolas Tabares";
            emp5.Dni = 38543781;
            emp5.Matricula = 234876;
            Empleado emp6 = new Empleado();
            emp6.Nombre = "Morena Leyes";
            emp6.Dni = 35987321;
            emp6.Matricula = 643897;
            Empleado emp7 = new Empleado();
            emp7.Nombre = "Lucia Rivas";
            emp7.Dni = 12285208;
            emp7.Matricula = 100991;
            Empleados.Add(emp1);
            Empleados.Add(emp2);
            GestiondelPersonal personal = new GestiondelPersonal(emp5);
            GestiondelPersonal personal1 = new GestiondelPersonal(emp5);
            personal.ShowDialog();
           
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
    }
}
