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
        List<Empleado> Empleados;
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
        //private void BtnCrear_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    AltaEmpleadoForm AltaEmp = new AltaEmpleadoForm();
        //    AltaEmp.ShowDialog();

        //}

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            //Cuando cambia el texto del textbox, aplicamos el filtro
            AplicarFiltro();
        }
        //void ActualizarListado()
        //{
        //    for (int i = 0; i < Empleados.Count;i++ )
        //    {
        //        Label label = new Label();
        //        label.Text = Empleados[i].Nombre;
        //        //panel.Controls.Add(label);
                
        //    }
        //}  

      

        private void listaDePersonasControl_Load(object sender, EventArgs e)
        {

        }

        private void GestionPersonalForm_Load(object sender, EventArgs e)
        {

        }

        //private System.Windows.Forms.TextBox BuscartextBox;
        //private System.Windows.Forms.Button crearButton;

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
                //string letras = filtroTextBox.Text.ToUpper();
                //List<Empleado> Coincidencias = Empleados.FindAll((Empleado elem) => elem.Nombre.StartsWith(letras.ToUpper()));
                        
        }
    }

}

