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

            //Cargamos el control personalizado con la informacion de la base de datos.
            listaDeEmpleadosControl.SetItems(BaseDeDatos.Empleados);

            //Nos registramos a los eventos.
            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += CrearButton_Click;
        }

        //Esto es un predicado.
        bool FiltroDePersonas(Empleado p)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (p.Nombre.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            //Usamos la funcion que creamos en el control personalizado.
            listaDeEmpleadosControl.Filtrar(FiltroDePersonas);
        }

        void RefrescarLista()
        {
            //Actualizamos la lista
            listaDeEmpleadosControl.SetItems(BaseDeDatos.Empleados);
            //Volvemos a aplicar el fitro
            AplicarFiltro();
        }

        void ActualizarListado()
        {
            for (int i = 0; i < Empleados.Count;i++ )
            {
                Label label = new Label();
                label.Text = Empleados[i].Nombre;
                panel2.Controls.Add(label);
                
            }
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            //Creamos el form
            AltaEmpleadoForm form = new AltaEmpleadoForm();
            //Usamos ShowDialog para que esta se bloquee hasta que terminen de usar el form de creacion.
            form.ShowDialog();

            //cuando cerro la ventana de creacion, refrescamos la lista de items.
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
        private Controles.ListaDeEmpleados.ListaDeEmpleadosControl listaDeEmpleadosControl;
        private System.Windows.Forms.TextBox filtroTextBox;
        private System.Windows.Forms.Button crearButton;

        private void NombresPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {            
                string letras = BuscartextBox.Text.ToUpper();
                List<Empleado> Coincidencias = Empleados.FindAll((Empleado elem) => elem.Nombre.StartsWith(letras.ToUpper()));
                        
        }
    }

}

