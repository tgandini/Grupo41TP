using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
