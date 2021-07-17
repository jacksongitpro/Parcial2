using Parcial.Controls;
using Parcial;
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

namespace Parcial.Forms.Controles.ListaDeEmpleados
{
    public partial class GestionPersonalForm : Form
    {
        //List<Empleado> Empleados;
        public GestionPersonalForm()
        {
            InitializeComponent();
            ListaDeEmpleadosControl.SetItems(BaseDeDatos.Empleados);

            //Nos registramos a los eventos.
            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            BtnCrear.Click += BtnCrear_Click;
        }

        //Esto es un predicado.
        bool FiltroDeEmpleados(Empleado p)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (p.Nombre.ToUpper().Contains(filtro) || p.Dni.Contains(filtro) || p.Matricula.Contains(filtro));
        }

        void AplicarFiltro()
        {
            //Usamos la funcion que creamos en el control personalizado.
            ListaDeEmpleadosControl.FiltrarEmpleados(FiltroDeEmpleados);
        }

        void RefrescarLista()
        {
            //Actualizamos la lista
            ListaDeEmpleadosControl.SetItems(BaseDeDatos.Empleados);
            //Volvemos a aplicar el fitro
            AplicarFiltro();
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {           
            AltaEmpleadoForm form = new AltaEmpleadoForm();
            form.ShowDialog();
            RefrescarLista();
        }
      

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            //Cuando cambia el texto del textbox, aplicamos el filtro
            AplicarFiltro();
        }     

        private void listaDePersonasControl_Load(object sender, EventArgs e)
        {

        }

        private void GestionPersonalForm_Load(object sender, EventArgs e)
        {

        }   

        private void NombresPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }        

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {           
               
                        
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenuPrincipal Form = new MenuPrincipal();
            this.Hide();
            Form.ShowDialog();
        }
    }

}

