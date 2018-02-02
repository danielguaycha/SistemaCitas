using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.View;

namespace ProisProject
{
    /*
     * Tipos de Usuario:
     * 0 : Administrador
     * 1 : Medico
     * 2 : Otro personal medico
     * 3 : Paciente
     */
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Controller.PermControlller perm = new Controller.PermControlller();
           // perm.init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Index());
        }
    }
}
