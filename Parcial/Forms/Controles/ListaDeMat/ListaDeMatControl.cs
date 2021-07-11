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
    public partial class ListaDeMatControl : UserControl
    {
        List<ListaDeMatItem> Items = new List<ListaDeMatItem>();

        public ListaDeMatControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
        }

        public void SetMatItems(List<Material> materiales)
        {
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();

            for (int i = 0; i < materiales.Count; i++)
            {
                ListaDeMatItem item = new ListaDeMatItem(materiales[i]);
                item.Width = flowLayoutPanel1.Width - 25;

                Items.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        public void FiltrarMat(Predicate<Material> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Material);
            }
        }

        void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoDeItems();
        }

        void ActualizarAnchoDeItems()
        {
            for (int i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                flowLayoutPanel1.Controls[i].Width = flowLayoutPanel1.Width - 25;
            }
        }
    }
}