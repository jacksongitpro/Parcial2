using Parcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial.Controls;


namespace Parcial.Forms.Controles.ListaDeEspecialidades
{
    public partial class ListaDeEspecialidadesControl : UserControl
    {
        List<ListaDeEspecialidadesItems> Items = new List<ListaDeEspecialidadesItems>();

        /*
         Propiedades usadas para ListaDePersonasControl:
            BorderStyle = FixedSingle
         Propiedades usadas para flowLayoutPanel1:
            AutoScroll = true
            Dock = Fill
            FlowDirection = TopDown
            WrapContents = false
        */
        public ListaDeEspecialidadesControl()
        {
            InitializeComponent();
            flowLayoutPanel1.SizeChanged += FlowLayoutPanel1_SizeChanged;
            
        }

        public void SetItems(List<Especialidad> especialidades)
        {
            //Quitamos todos los elementos de la lista y del panel
            flowLayoutPanel1.Controls.Clear();
            Items.Clear();
            //recorremos los elementos de la lista recibida y creamos controles para cada uno
            for (int i = 0; i < especialidades.Count; i++)
            {
                ListaDeEspecialidadesItems item = new ListaDeEspecialidadesItems(especialidades[i]);               
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


        //Si ajustamos el ancho del panel, es necesario actualizar el ancho de los items tambien.
        void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            ActualizarAnchoDeItems();
        }


        //Si ajustamos el ancho del panel, es necesario actualizar el ancho de los items tambien.
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

        private void ListaDeEspecialidadesControl_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}