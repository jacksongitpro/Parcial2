using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//JacksonGarcia

namespace Parcial
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

            if (PassConfirmtextBox == PassNuevaBox)
            {

                PassNuevaBox.Clear();
                PassNuevaBox.Focus();
                MessageBox.Show("ingrese claves iguales");
            }
            else
            {
                admincreado.password = PassNuevaBox.Text;
                admincreado.nombre = admincreado.nombre;
                admincreado.codigo = admincreado.codigo;

                BaseDeDatos.Usuarios.Add(admincreado);
                BaseDeDatos.Usuarios.RemoveAt(0);

                Ingreso Form = new Ingreso(/*admincreado*/);
                Form.ShowDialog();
            }



        }
        public void SetUsuario(Usuario admincreado)
        {
            admincreado.nombre = "admin";
            admincreado.password = PassNuevaBox.Text;
            admincreado.codigo = "12345";
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
                //MessageBox.Show("!!Bienvenido!!");
                RtaSecretatextBox.Clear();
                PassNuevaBox.Enabled = true;
                PassConfirmtextBox.Enabled = true;

            }
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PassConfirmtextBox_TextChanged(object sender, EventArgs e)
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
                PassConfirmtextBox.Enabled = true;

            }
        }
    }
    }

