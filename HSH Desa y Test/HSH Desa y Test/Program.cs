using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Forms;
using HSH_Desa_y_Test.xUC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new xfFormTest());
        }
    }
}
