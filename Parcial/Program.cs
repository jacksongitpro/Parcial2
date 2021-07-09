using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BaseDeDatos.CargarUsuario();//JacksonGarcia
            BaseDeDatos.Cargar();//Agustin
            BaseDeDatos.CargarDM();//Jehiel
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new Ingreso());           

        }

    }
}
