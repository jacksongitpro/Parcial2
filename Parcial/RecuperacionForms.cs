using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parcial //JacksonGarcia
{
    public partial class RecuperacionForms : Form
    {
        List<Usuario> Usuarios;
        Usuario admincreado = new Usuario();
        public RecuperacionForms()
        {

            InitializeComponent();
            usuariocombo.DataSource = BaseDeDatos.Usuarios;
            usuariocombo.DisplayMember = "nombre";
            btncambiar.Click += btncambiar_Click;
            SetUsuario(admincreado);
        }

        private void RecuperacionForms_Load(object sender, EventArgs e)
        {

        }

        private void passNueva_Click(object sender, EventArgs e)
        {

        }

        private void EmailtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncambiar_Click(object sender, EventArgs e)
        {

            if (PassConfirmBox.Text != PassNuevaBox.Text)
            {
                PassNuevaBox.Clear();
                PassNuevaBox.Focus();
                MessageBox.Show("ingrese claves iguales");
            }
            else if (PassConfirmBox.Text == PassNuevaBox.Text)
            {
                admincreado.password = PassNuevaBox.Text;
                admincreado.nombre = admincreado.nombre;
                admincreado.codigo = admincreado.codigo;
                BaseDeDatos.Usuarios.RemoveAt(0);
                BaseDeDatos.Usuarios.Add(admincreado);
                

                Ingreso Form = new Ingreso();
                Form.ShowDialog();
            }



        }
        public void SetUsuario(Usuario admincreado)
        {
            admincreado.nombre = "admin";            
            admincreado.codigo = "12345";
            if (PassNuevaBox.Text == PassConfirmBox.Text)
            {admincreado.password = PassNuevaBox.Text;}
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (RtaSecretatextBox.Text == admincreado.codigo)
            {
                MessageBox.Show("!!ERROR!! Codigo invalido");
                RtaSecretatextBox.Clear();
                RtaSecretatextBox.Focus();
                return;
            }
            else
            {                
                RtaSecretatextBox.Clear();
                PassNuevaBox.Enabled = true;
                PassConfirmBox.Enabled = true;
            }
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassConfirmBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PassNuevaBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            if (RtaSecretatextBox.Text != admincreado.codigo)
            {
                MessageBox.Show("!!ERROR!! Codigo invalido");
                RtaSecretatextBox.Clear();
                RtaSecretatextBox.Focus();
                return;
            }
            else
            {
                //MessageBox.Show("!!Bienvenido!!");
                RtaSecretatextBox.Clear();
                PassNuevaBox.Enabled = true;
                PassConfirmBox.Enabled = true;

            }
        }

        private void RtaSecretatextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

