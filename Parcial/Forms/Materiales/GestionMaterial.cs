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

namespace Parcial
{
    public partial class GestionMaterial : Form
    {
        public GestionMaterial()
        {
            InitializeComponent();

            listaDeDeptosControl.SetDeptoItems(BaseDeDatos.Departamentos);

            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += CrearButton_Click;
        }

        bool FiltroDeDeptos(Departamento dep)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (dep.Nombre.ToUpper().Contains(filtro) || dep.Direccion.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            listaDeDeptosControl.FiltrarDepto(FiltroDeDeptos);
        }

        void RefrescarLista()
        {
            listaDeDeptosControl.SetDeptoItems(BaseDeDatos.Departamentos);

            AplicarFiltro();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
          CrearDepartamento form = new CrearDepartamento();

            form.ShowDialog();

            RefrescarLista();
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void GestionMaterial_Load(object sender, EventArgs e)
        {

        }

        private void filtroTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void crearButton_Click_1(object sender, EventArgs e)
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