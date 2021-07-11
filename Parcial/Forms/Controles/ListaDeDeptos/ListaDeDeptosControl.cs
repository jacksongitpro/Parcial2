
using Parcial.Controls.ListaDeDeptos;
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

namespace Parcial.Forms.Controles.ListaDeDeptos
{
   
    public partial class ListaDeDeptosControl : UserControl
    {
        List<ListaDeDeptosItem> Items = new List<ListaDeDeptosItem>();
        public ListaDeDeptosControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
        }

        public void SetDeptoItems(List<Departamento> departamentos)
        {
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();

            for (int i = 0; i < departamentos.Count; i++)
            {
                ListaDeDeptosItem item = new ListaDeDeptosItem(departamentos[i]);
                item.Width = flowLayoutPanel1.Width - 25;

                Items.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }

        public void FiltrarDepto(Predicate<Departamento> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Departamento);
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
