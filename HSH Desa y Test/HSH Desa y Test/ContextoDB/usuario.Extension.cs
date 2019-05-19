using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class usuario
    {
        public usuario(string Pnombre, string Papellido, string Ppass, string Pmail, string PfechaNac)
        {
            this.nombre = Pnombre;
            this.apellido = Papellido;
            this.contraseña = Ppass;
            this.mail = Pmail;
            this.fecha_nacimiento = DateTime.Parse(PfechaNac);
            this.premium = false;
            this.token = 2;
            this.tarjetas = new List<tarjeta>();
            this.usuarioParticipaEnSubastas = new List<usuarioParticipaEnSubasta>();

        }

        public static usuario traerDeDb(string mailParam, string mailPass)
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                if (!conexion.usuarios.Any(p => p.mail == mailParam))
                {
                    MessageBox.Show(string.Format("El mail {0} no se encuentra registrado", mailParam));
                    return null;
                }
                else
                {
                    var usuarioEnDB = conexion.usuarios.Where(p => p.mail == mailParam && p.contraseña == mailPass).FirstOrDefault();
                    if (usuarioEnDB != null)
                    {
                        MessageBox.Show(string.Format("Logueado como usuario: {0}", mailParam));
                        return usuarioEnDB;
                    }
                    else
                    {
                        MessageBox.Show("ERROR. Contraseña inválida");
                        return null;
                    }
                }
            }
        }
        public static Boolean validarMail(string mail)
        {
            var foo = new EmailAddressAttribute();
            return (foo.IsValid(mail));

        }

        public static Boolean existeMailEnBaseDeDatos(string mail)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var mailEnDB = conec.usuarios.Where(each => each.mail == mail).FirstOrDefault();
                return mailEnDB != null;
            }

        }
    }
}
