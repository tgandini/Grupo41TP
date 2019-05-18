using HSH_Desa_y_Test.ContextoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.Modelo_Expandido
{
    class Sesion
    {
        public static usuario user;
        public static admin admin;

        public static bool hayUserLogueado()
        {
            return user != null;
        }
        public static bool hayAdminLogueado()
        {
            return admin != null;
        }
    }
}
