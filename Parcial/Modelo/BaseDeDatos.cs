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
            Especialidad Odontologia = new Especialidad()
            {
                Descripcion = "Es la medicina dedicada al cuidado de la Salud bucal de la Poblacion",
                Nombre = "Odontologia",
            }; Especialidades.Add(Odontologia);

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

            Empleado emp1 = new Empleado()
            {
                Nombre = "Fernando Galvez",
                Dni = "38401865",
                Matricula = "123321",
                Calle = "La Ciudad de la Furia",
                Especialidad = Odontologia,
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp1);
            
            Empleado emp2 = new Empleado()
            {
                Nombre = "Pedro perez",
                Dni = "95654789",
                Matricula = "656584",
                Calle = "La Ciudad de la Furia",
                Especialidad = Ginecologia,
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp2);            

            Empleado emp3 = new Empleado()
            {
                Nombre = "Gaston Robles",
                Dni = "95654789",
                Matricula = "876321",
                Especialidad = Cardiologia,
                Calle = "La Ciudad de la Furia",
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp3); 

            Empleado emp4 = new Empleado()
            {
                Nombre = "Ruben caré",
                Dni = "37653865",
                Matricula = "999342",
                Especialidad = Cardiologia,
                Calle = "La Ciudad de la Furia",
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp4);
            Empleado emp5 = new Empleado()
            {
                Nombre = "Nicolas Tabares",
                Dni = "38543781",
                Matricula = "234876",
                Especialidad = Ginecologia,
                Calle = "La Ciudad de la Furia",
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp5);

            Empleado emp6 = new Empleado()
            {
                Nombre = "Morena Leyes",
                Dni = "35987321",
                Matricula = "643897",
                Especialidad = Cardiologia,
                Calle = "La Ciudad de la Furia",
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp6);

            Empleado emp7 = new Empleado()
            {
                Nombre = "Martin Peralta",
                Dni = "35401266",
                Matricula = "423351",
                Especialidad = Ginecologia,
                Calle = "La Ciudad de la Furia",
                Telefono = "1561199556",
                Email = "PEPE@ClinicaIstea.com",
                Localidad = "La Ferrere",
                Provincia = "Buenos Aires"
            }; Empleados.Add(emp7);       
               
        }
        public static void CargarDM()
        {
            Material mat = new Material()
            {
                Nombre = "Guantes Descartables",
                Cantidad = 100
            };        

            Departamento Ginecologia = new Departamento()
            {
                Nombre = "Departamento De Ginecologia",
                Direccion = "Avenida Rivadavia",
                Material = mat
            };

            Departamentos.Add(Ginecologia);
            Materiales.Add(mat);

            Material mat2 = new Material()
            {
                Nombre = "Inyectadoras",
                Cantidad = 50
            };

            Departamento Odontologia = new Departamento()
            {
                Nombre = "Departamento De Odontologia",
                Direccion = "Avenida Corrientes",
                Material = mat2
            };
            Departamentos.Add(Odontologia);
            Materiales.Add(mat2);
            Material mat3 = new Material()
            {
                Nombre = "Algodon",
                Cantidad = 80
            }; Materiales.Add(mat3);

            Departamento Pediatria = new Departamento()
            {
                Nombre = "Departamento De Pediatria",
                Direccion = "Avenida 9 de Julio",
                Material = mat3
            }; Departamentos.Add(Pediatria);


        }
    }
}
