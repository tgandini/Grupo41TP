using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class HotSale
    {
        public HotSale(DateTime inicio, DateTime fin, decimal precio, int semana, int año)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = precio;
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
        }
    }
}
