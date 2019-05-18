using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class tarjeta
    {
        public tarjeta(string pNumeroTarjeta,DateTime pFechaVenc, string pCodigoSeguridad)
        {
            this.id = int.MaxValue;
            this.numero = pNumeroTarjeta.Replace("-",string.Empty);
            this.vencimiento = pFechaVenc;
            this.codigoSeguridad = pCodigoSeguridad;
        }
    }
}
