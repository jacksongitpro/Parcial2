
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

namespace Parcial.Controls.ListaDeDeptos
{
    public partial class ListaDeDeptosItem : UserControl
    {
        public Departamento Departamento;

        public ListaDeDeptosItem()
        {
            InitializeComponent();
        }

        public ListaDeDeptosItem(Departamento dep)
        {
            InitializeComponent();
            infoButton.Click += infoButton_Click;
            SetDepartamento(dep);
        }

        void SetDepartamento(Departamento dep)
        {
            Departamento = dep;

            nombreLabel.Text = $"{Departamento.Nombre}";
            direccionLabel.Text = $"{Departamento.Direccion}";
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            Forms.Materiales.DetalleDepartamento form = new Forms.Materiales.DetalleDepartamento(Departamento);
            form.ShowDialog();

        }

        private void ListaDeDeptosItem_Load(object sender, EventArgs e)
        {

        }
    }
}