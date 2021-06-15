using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class GestiondelPersonal : Form
    {
        List<Empleado> ListaEmpleados = new List<Empleado>();
        public Empleado P;
        //private List<Empleado> Empleados;

        public GestiondelPersonal()
        {
            InitializeComponent();
            BuscartextBox.TextChanged += BuscartextBox_TextChanged;
            ;
        }
        bool FiltroDeDeptos(Empleado emp)
        {
            string filtro = BuscartextBox.Text.ToUpper();

            return filtro.Length < 2 || (emp.Nombre.ToUpper().Contains(filtro) || emp.Especialidad.ToUpper().Contains(filtro));
        }
        void AplicarFiltro()
        {
            
        }


        public GestiondelPersonal(Empleado P)
        {
           
            InitializeComponent();
            SetPersona(P);
        }

       

        public void SetPersona(Empleado P)
        {
            nombredescilabel6.Text = P.Nombre;
            nummatriculalabel4.Text = $"{P.Matricula}";
            numdnilabel5.Text = $"{P.Dni}";
            label1.Text = P.Nombre;
            label3.Text = $"{P.Matricula}";
            label2.Text = $"{P.Dni}";
            label7.Text = P.Nombre;
            label8.Text = $"{P.Matricula}";
            label9.Text = $"{P.Dni}";
            label13.Text = P.Nombre;
            label15.Text = $"{P.Matricula}";
            label14.Text = $"{P.Dni}";
            label16.Text = P.Nombre;
            label18.Text = $"{P.Matricula}";
            label17.Text = $"{P.Dni}";
            label19.Text = P.Nombre;
            label21.Text = $"{P.Matricula}";
            label20.Text = $"{P.Dni}";
            label25.Text = P.Nombre;
            label27.Text = $"{P.Matricula}";
            label26.Text = $"{P.Dni}";




        }
        

        private void Verbutton1_Click(object sender, EventArgs e)
        {
            
            Empleado emp1 = new Empleado();
            
            emp1.Nombre = "Fernando Galvez";
            emp1.Dni = 38401865;
            emp1.Matricula = 123321;
            emp1.Telefono = 1532456432;
            emp1.Email = "Ferga@hotmail.com";
            emp1.Calle = "goya 232";
            emp1.Localidad = "Lanus";
            emp1.Provincia = "Salta";
            emp1.Especialidad = "Oftalmologo";
            emp1.Descripcion = "Un oftalmólogo es un médico especializado en el cuidado de los ojos y el sistema visual.";
            
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp1);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp1);

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp2 = new Empleado();
            emp2.Nombre = "Gaston Robles";
            emp2.Dni = 33561867;
            emp2.Matricula = 876321;
            emp2.Telefono = 1532456432;
            emp2.Email = "FRobles@hotmail.com";
            emp2.Calle = "raneu 232";
            emp2.Localidad = "Beccar";
            emp2.Provincia = "BsAs";
            emp2.Especialidad = "Traumatologo";
            emp2.Descripcion = "La traumatología es la rama de la medicina que se dedica al estudio de las lesiones del aparato locomotor..";
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp2);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado emp3 = new Empleado();
            emp3.Nombre = "Martin Peralta";
            emp3.Dni = 35401266;
            emp3.Matricula = 423351;
            emp3.Telefono = 1532454332;
            emp3.Email = "Mperalta@hotmail.com";
            emp3.Calle = "Mane 232";
            emp3.Localidad = "Junin";
            emp3.Provincia = "BsAs";
            emp3.Especialidad = "Nutricionista";
            emp3.Descripcion = "Profesional encargado de brindar educación alimentaria y dar la consejería nutricional necesaria para que cada paciente pueda lograr sus objetivos.";
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp3);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleado emp4 = new Empleado();
            emp4.Nombre = "Ruben caré";
            emp4.Dni = 37653865;
            emp4.Matricula = 999342;
            emp4.Telefono = 1549817564;
            emp4.Email = "Rcare@hotmail.com";
            emp4.Calle = "ronceu232";
            emp4.Localidad = "San isidro";
            emp4.Provincia = "BsAs";
            emp4.Especialidad = "Odontologo";
            emp4.Descripcion = " El odontólogo/a se encarga de la prevención, el diagnóstico y el tratamiento de las enfermedades bucales como son: caries, enfermedades periodontales y maloclusiones, con una visión integradora (bio-psico-social) y con el objetivo de conservar y/o rehabilitar el sistema estomatognático.";
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp4);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Empleado emp5 = new Empleado();
            emp5.Nombre = "Nicolas Tabares";
            emp5.Dni = 38543781;
            emp5.Matricula = 234876;
            emp5.Telefono = 1532446574;
            emp5.Email = "Nico_RTAV@hotmail.com";
            emp5.Calle = "Terendal 545";
            emp5.Localidad = "Lugano";
            emp5.Provincia = "BsAs";
            emp5.Especialidad = "Ginecologo";
            emp5.Descripcion = "Ginecología que significa literalmente ciencia de la mujer y en medicina hace referencia a la especialidad médica y quirúrgica que estudia el sistema reproductor femenino.";
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp5);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp5);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Empleado emp6 = new Empleado();
            emp6.Nombre = "Morena Leyes";
            emp6.Dni = 35987321;
            emp6.Matricula = 643897;
            emp6.Telefono = 1532446574;
            emp6.Email = "Mleyes@hotmail.com";
            emp6.Calle = "Sander 545";
            emp6.Localidad = "Victoria";
            emp6.Provincia = "BsAs";
            emp6.Especialidad = "Kinesiologo";
            emp6.Descripcion = "La kinesiología o quinesilogía​​ es el estudio científico del movimiento del cuerpo.La kinesiología aborda los principios y mecanismos de movimientos fisiológicos, biomecánicos y psicodinámicos";
            DetalleDelEmpleado DetalleEmpleado = new DetalleDelEmpleado(emp6);
            DetalleEmpleado.Show();
            ListaEmpleados.Add(emp6);
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

       
    }
}
