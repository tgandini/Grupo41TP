using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCPerfilDeUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCPerfilDeUsuario()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            nombreControl.Text = Sesion.user.nombre;
            apellidoControl.Text = Sesion.user.apellido;
            mailControl.Text = Sesion.user.mail;
            fechaNacimientoControl.Text = Sesion.user.fecha_nacimiento.ToString();
            tokenControl.Text = Sesion.user.token.ToString();
            List<tarjeta> tar = llenarConTarjetas(Sesion.user.mail);
            if (tar != null)
            {
                List<string> numT = new List<string>();
                foreach (tarjeta num in tar)
                {
                    numT.Add(num.numero);
                }
                comboBox1.DataSource = numT;
            }
        }

        private List<tarjeta> llenarConTarjetas(string idenUsuario)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {

                return conec.tarjetas.Where(p => p.idPersona == idenUsuario).ToList();

            }
        }
    }
}
