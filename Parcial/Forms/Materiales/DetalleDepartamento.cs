
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial.Forms.Materiales
{
    public partial class DetalleDepartamento : Form
    {
        Departamento Departamento;

        public DetalleDepartamento()
        {
            InitializeComponent();

           // listaDeMatControl.SetMatItems(BaseDeDatos.Materiales);

            filtroTextBox.TextChanged += FiltroTextBox_TextChanged;
            crearButton.Click += CrearButton_Click;
        }

        public DetalleDepartamento(Departamento departamento)
        {
            InitializeComponent();
            SetDepto(departamento);

        }

        void SetDepto(Departamento dep)
        {
            Departamento = dep;
            listaDeMatControl.SetMatItems(dep.Materiales);
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
            listaDeMatControl.SetMatItems(Departamento.Materiales);
            AplicarFiltro();
        }

        private void CrearButton_Click(object sender, EventArgs e)
        {
            CrearMaterial form = new Forms.CrearMaterial();

            form.ShowDialog();

            RefrescarLista();
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

    }
}