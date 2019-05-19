using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class Propiedad
    {
        public Propiedad(int iden, string tipoProp, string ubicacionProp, int cantHabitaciones, string adminQueDioDeAlta, DateTime fechaAltaProp)
        {
            this.id = iden;
            this.tipo = tipoProp;
            this.ubicaciòn = ubicacionProp;
            this.habitaciones = cantHabitaciones;
            this.adminQueDioDeAltaProp = adminQueDioDeAlta;
            this.fechaAlta = fechaAltaProp;
        }
    }
}
