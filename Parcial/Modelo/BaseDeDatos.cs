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
        public static void CargarEspecialidad()
        {
            Especialidad Cardiologia = new Especialidad()
            {
                Descripcion = "Cardiologia es la rama de la medicina que se encarga del estudio, diagnóstico y tratamiento" +
                " de las enfermedades del corazón y del sistema circulatorio. ",
                Nombre = "Cardiologia",
            };Especialidades.Add(Cardiologia);

            Especialidad Ginecologia = new Especialidad()
            {
                Descripcion = "Es la medicina dedicada al cuidado del sistema reproductor femenino",
                Nombre = "Ginecologia",
            }; Especialidades.Add(Ginecologia);
            Especialidad Odontologia = new Especialidad()
            {
                Descripcion = "Es la medicina dedicada al cuidado de la Salud bucal de la Poblacion",
                Nombre = "Odontologia",
            }; Especialidades.Add(Odontologia);
        }

        public static void Cargar()
        {           

            Especialidad Odontologia = new Especialidad()
            {
                Descripcion = "Es la medicina dedicada al cuidado de la Salud bucal de la Poblacion",
                Nombre = "Odontologia",
            }; Especialidades.Add(Odontologia);
            Empleado emp1 = new Empleado()
            {
                Nombre = "Fernando Galvez",
                Dni = 38401865,
                Matricula = 123321,
                Especialidad = Odontologia
            }; Empleados.Add(emp1);

            Especialidad Ginecologia = new Especialidad()
            {
                Descripcion = "Es la medicina dedicada al cuidado del sistema reproductor femenino",
                Nombre = "Ginecologia",
            }; Especialidades.Add(Ginecologia);

            Especialidad Cardiologia = new Especialidad()
            {
                Descripcion = "Cardiologia es la rama de la medicina que se encarga del estudio, diagnóstico y tratamiento" +
               " de las enfermedades del corazón y del sistema circulatorio. ",
                Nombre = "Cardiologia",
            }; Especialidades.Add(Cardiologia);

            Empleado emp2 = new Empleado()
            {
                Nombre = "Gaston Robles",
                Dni = 95654789,
                Matricula = 876321,
                Especialidad = Cardiologia
            }; Empleados.Add(emp2);

            Empleado emp3 = new Empleado()
            {
                Nombre = "Pedro perez",
                Dni = 95654789,
                Matricula = 656584,
                Especialidad = Ginecologia
            }; Empleados.Add(emp3);           
           
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
            Empleado emp7 = new Empleado();
            emp7.Nombre = "Martin Peralta";
            emp7.Dni = 35401266;
            emp7.Matricula = 423351;


          
            Empleados.Add(emp4);
            Empleados.Add(emp5);
            Empleados.Add(emp6);
            Empleados.Add(emp7);




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
