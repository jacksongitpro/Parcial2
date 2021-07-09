using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parcial//JacksonGarcia
{
    public partial class MiCuenta : Form
    {
       
        List<Usuario> Usuarios;


        public MiCuenta()
        {
            InitializeComponent();            
            usuariocombo.DataSource = BaseDeDatos.Usuarios;
            usuariocombo.DisplayMember = "nombre";
            Usuarios = BaseDeDatos.Usuarios;

        }
        private void BTNGestionar_Click(object sender, EventArgs e)
        {

            Usuario user = Usuarios.Find((Usuario admin) => admin.password == ClaveActualtextBox.Text);

            if (user.password == ClaveActualtextBox.Text)
            {                
                CambiarClavetextBox.Enabled = true;
                CambiarCodigotextBox.Enabled = true;
            }

            else
            {
                MessageBox.Show("!!ERROR!! contraseña invalida");
                ClaveActualtextBox.Clear();
                ClaveActualtextBox.Focus();
                return;

            }

        }
        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            Usuario user = Usuarios.Find((Usuario admin) => admin.password == ClaveActualtextBox.Text);
            
            user.password = CambiarClavetextBox.Text;
            user.codigo = CambiarCodigotextBox.Text;
            user.nombre = "admin";
            Usuarios.RemoveAt(0);
            Usuarios.Add(user);            
            this.Hide();
            MenuPrincipal Form = new MenuPrincipal();         
            Form.ShowDialog();
            
        }
        private void MiCuenta_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }      
              
    }
}
