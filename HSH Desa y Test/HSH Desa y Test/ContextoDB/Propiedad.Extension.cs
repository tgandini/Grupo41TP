using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class Propiedad
    {
        public Propiedad(string tipoProp, string ubicacionProp, int cantHabitaciones, string adminQueDioDeAlta, DateTime fechaAltaProp)
        {
            this.tipo = tipoProp;
            this.ubicaciòn = ubicacionProp;
            this.habitaciones = cantHabitaciones;
            this.adminQueDioDeAltaProp = adminQueDioDeAlta;
            this.fechaAlta = fechaAltaProp;
            this.id = int.MaxValue;
            this.fotos = new List<foto>();
        }


        public static bool existeDireccion(string ubi)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var mailEnDB = conec.Propiedads.Where(each => each.ubicaciòn == ubi).FirstOrDefault();
                return mailEnDB != null;
            }

        }
    }
}
