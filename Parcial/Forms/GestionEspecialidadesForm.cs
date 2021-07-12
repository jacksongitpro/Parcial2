
using Parcial.Forms.Controles.ListaDeEspecialidades;
using Parcial.Modelo;
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
    public partial class GestionEspecialidadesForm : Form
    {
        public GestionEspecialidadesForm()
        {
            InitializeComponent();
            ListaDeEspecialidadesControl.SetItems(BaseDeDatos.Especialidades);
            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
        }
        bool FiltroDeEspecialidades(Especialidad especialidad)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (especialidad.Nombre.ToUpper().Contains(filtro) || especialidad.Descripcion.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            //Usamos la funcion que creamos en el control personalizado.
            ListaDeEspecialidadesControl.Filtrar(FiltroDeEspecialidades);
        }
        void RefrescarLista()
        {
            //Actualizamos la lista
            ListaDeEspecialidadesControl.SetItems(BaseDeDatos.Especialidades);
            //Volvemos a aplicar el fitro
            AplicarFiltro();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            //Creamos el form
            AltaEspecialidadesForm form = new AltaEspecialidadesForm();

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
        private void btnCrear_Click(object sender, EventArgs e)
        {
            AltaEspecialidadesForm AltaEsp = new AltaEspecialidadesForm();
            AltaEsp.ShowDialog();
        }
        //private void ListaDeEspecialidadesControl_Load(object sender, EventArgs e)
        //{

        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void filtroTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void FormEspecialidades_Load(object sender, EventArgs e)
        {

        }
    }
}
