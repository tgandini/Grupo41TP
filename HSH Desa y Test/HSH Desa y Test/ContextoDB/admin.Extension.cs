using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class admin
    {
        public admin(string tok)
        {
            this.token = tok;
        }

        public static admin traerDeDb(string tokenParam)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var adminLogueado = conec.admins.Where(p => p.token == tokenParam).FirstOrDefault();
                if (adminLogueado != null)
                {
                    MessageBox.Show("Logueado como administrador con éxito");
                    return adminLogueado; 
                }
                else
                {
                    MessageBox.Show("Token de adminstrador Inválido");
                    return null;
                }
            }
        }
    }
}
