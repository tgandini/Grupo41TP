using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class tarjeta
    {
        public tarjeta(string pNumeroTarjeta, DateTime pFechaVenc, string pCodigoSeguridad)
        {
            this.id = int.MaxValue;
            this.numero = tarjeta.sacarGuiones(pNumeroTarjeta);
            this.vencimiento = pFechaVenc;
            this.codigoSeguridad = pCodigoSeguridad;
        }
        public tarjeta()
        {

        }

        public static string sacarGuiones(string numConGuiones)
        {
            return numConGuiones.Replace("-", string.Empty);
        }

        internal static bool ValidarFechaVencimiento(string text)
        {

            if (DateTime.ParseExact(text, "MM/yyyy", CultureInfo.InvariantCulture).Year < DateTime.Today.Year) return false;
            else if (DateTime.ParseExact(text, "MM/yyyy", CultureInfo.InvariantCulture).Month < DateTime.Today.Month) return false;
            else return true;
        }
    }
}
