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

namespace Parcial
{
    public partial class DetalleDelEmpleado : Form
    {
        public Empleado persona;
        public DetalleDelEmpleado()
        {
            InitializeComponent();
        }
        public DetalleDelEmpleado(Empleado P)
        {
            InitializeComponent();
            SetPersona(P);
        

        }
        public void SetPersona(Empleado P)
        {
            Nombreinf_label4.Text = P.Nombre;
            MatriculaInf_label6.Text = $"{P.Matricula}";
            Dniinf_label5.Text = $"{P.Dni}";
            TelContacto_label9.Text = $"{P.Telefono}";
            EmailContacto_label10.Text = P.Email;
            CalleDom__label17.Text = P.Calle;
            LocalidadDom_label18.Text = P.Localidad;
            ProvinciaDom_label.Text = P.Provincia;
            nomEspecialidad_label11.Text = P.Especialidad;
            DescEspecialidad_label13.Text = P.Descripcion;



        }




       
    }
}
