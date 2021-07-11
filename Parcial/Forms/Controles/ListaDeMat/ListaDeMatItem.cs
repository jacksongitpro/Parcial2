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

namespace Parcial.Forms.Controles.ListaDeMat
{
    public partial class ListaDeMatItem : UserControl
    {
        public Material Material;
        public ListaDeMatItem()
        {
            InitializeComponent();
        }

        public ListaDeMatItem(Material mat)
        {
            InitializeComponent();
            SetMaterial(mat);
        }

        void SetMaterial(Material mat)
        {
            Material = mat;

            nombreLabel.Text = $"{Material.Nombre}";
            cantidadNumericUpDown.Value = Material.Cantidad;
        }

        private void ListaDeMatItem_Load(object sender, EventArgs e)
        {

        }
    }
}
