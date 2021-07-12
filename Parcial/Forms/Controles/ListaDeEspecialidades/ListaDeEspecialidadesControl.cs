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

namespace Parcial.Forms.Controles.ListaDeEspecialidades
{
    public partial class ListaDeEspecialidadesControl : UserControl
    {
        List<ListaDeEspecialidadesItems> Items = new List<ListaDeEspecialidadesItems>();
        public ListaDeEspecialidadesControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;

        }

        //private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        public void SetItems(List<Especialidad> Especialidades)
        {
            //Quitamos todos los elementos de la lista y del panel
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();

            //recorremos los elementos de la lista recibida y creamos controles para cada uno
            for (int i = 0; i < Especialidades.Count; i++)
            {
                ListaDeEspecialidadesItems item = new ListaDeEspecialidadesItems(Especialidades[i]);
                item.Width = flowLayoutPanel1.Width - 25;

                //Los agregamos a la listita de items y al panel para que se vean.
                Items.Add(item);
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        public void Filtrar(Predicate<Especialidad> predicate)
        {
            //usamos el predicado para setear la propiedad de visible segun su resultado 
            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Visible = predicate(Items[i].Especialidad);
            }
        }
        void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoDeItems();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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