using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial.Forms;

namespace Parcial.Modelo
{
    public static class BaseDeDatos
    {
        
        public static List<Empleado> Empleados = new List<Empleado>();
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static List<Departamento> Departamentos = new List<Departamento>();
        public static List<Material> Materiales = new List<Material>();
        public static List<Especialidad> Especialidades = new List<Especialidad>();

        public static void CargarUsuario()
        {

            Usuario admin = new Usuario()
            {
                nombre = "admin",
                password = "admin",
                codigo = "12345",
                Pregunta = "Codigo secreto"

            }; Usuarios.Add(admin);
           

        }

        public static void Cargar()
        {


            Empleado emp1 = new Empleado();
            emp1.Nombre = "Fernando Galvez";
            emp1.Dni = 38401865;
            emp1.Matricula = 123321;
            Empleado emp2 = new Empleado();
            emp2.Nombre = "Gaston Robles";
            emp2.Dni = 33561867;
            emp2.Matricula = 876321;
            Empleado emp3 = new Empleado();
            emp3.Nombre = "Martin Peralta";
            emp3.Dni = 35401266;
            emp3.Matricula = 423351;
            Empleado emp4 = new Empleado();
            emp4.Nombre = "Ruben caré";
            emp4.Dni = 37653865;
            emp4.Matricula = 999342;
            Empleado emp5 = new Empleado();
            emp5.Nombre = "Nicolas Tabares";
            emp5.Dni = 38543781;
            emp5.Matricula = 234876;
            Empleado emp6 = new Empleado();
            emp6.Nombre = "Morena Leyes";
            emp6.Dni = 35987321;
            emp6.Matricula = 643897;
           
            
            Empleados.Add(emp1);
            Empleados.Add(emp2);
            Empleados.Add(emp3);
            Empleados.Add(emp4);
            Empleados.Add(emp5);
            Empleados.Add(emp6);    


    }
        public static void CargarDM()
        {
            Material mat = new Material()
            {
                Nombre = "Material 1",
                Cantidad = 0
            };

            Departamento dep = new Departamento()
            {
                Nombre = "Departamento Uno",
                Direccion = "Avenida Verdadera 789",
                Material = mat
            };

            Departamentos.Add(dep);
            Materiales.Add(mat);

            mat = new Material()
            {
                Nombre = "Material 2",
                Cantidad = 0
            };

            dep = new Departamento()
            {
                Nombre = "Departamento Dos",
                Direccion = "Calle Falsa 321",
                Material = mat
            };

            Departamentos.Add(dep);
            Materiales.Add(mat);
        }
    }
}
