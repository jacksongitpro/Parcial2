
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

namespace Parcial.Forms.Materiales
{
    public partial class DetalleDepartamento : Form
    {
        Departamento Departamento;

        public DetalleDepartamento()
        {
            InitializeComponent();

        }

        public DetalleDepartamento(Departamento departamento)
        {
            InitializeComponent();
            SetDepto(departamento);
            listaDeMatControl.SetMatItems(BaseDeDatos.Materiales);
            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += crearButton_Click_1;

        }
        void SetDepto(Departamento dep)
        {
            Departamento = dep;

            this.nombreLabel.Text = Departamento.Nombre;
            this.direccionLabel.Text = Departamento.Direccion;
        }

        bool FiltroDeMat(Material mat)
        {
            string filtro = filtroTextBox.Text.ToUpper();

            return filtro.Length < 2 || (mat.Nombre.ToUpper().Contains(filtro));
        }

        void AplicarFiltro()
        {
            listaDeMatControl.FiltrarMat(FiltroDeMat);
        }

        void RefrescarLista()
        {
            listaDeMatControl.SetMatItems(BaseDeDatos.Materiales);
            AplicarFiltro();
        }

        private void crearButton_Click_1(object sender, EventArgs e)
        {
            CrearMaterial form = new Forms.CrearMaterial();
            form.ShowDialog();
            RefrescarLista();
            
        }
        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        //private void CrearButton_Click(object sender, EventArgs e)
        //{
        //    CrearMaterial form = new Forms.CrearMaterial();
        //    form.ShowDialog();
        //    RefrescarLista();
        //}



        private void listaDeMatControl_Load(object sender, EventArgs e)
        {

        }

    }
}