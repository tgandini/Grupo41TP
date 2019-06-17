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

        public tarjeta(string pNumeroTarjeta, DateTime pFechaVenc, string pCodigoSeguridad, string mail)
        {
            this.id = int.MaxValue;
            this.numero = tarjeta.sacarGuiones(pNumeroTarjeta);
            this.vencimiento = pFechaVenc;
            this.codigoSeguridad = pCodigoSeguridad;
            this.idPersona = mail;
        }

        public static string sacarGuiones(string numConGuiones)
        {
            return numConGuiones.Replace("-", string.Empty);
        }

        internal static bool ValidarFechaVencimiento(string text)
        {
            var myCulture = (CultureInfo)CultureInfo.InstalledUICulture.Clone();
            myCulture.Calendar.TwoDigitYearMax = 2059;
            DateTime venc = DateTime.ParseExact(text, "MM/yy", myCulture);
            return (DateTime.Compare(venc, DateTime.Today) >= 0);
        }
    }
}
