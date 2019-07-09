using HSH_Desa_y_Test.ContextoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.Modelo_Expandido
{
    public class ReservaFutura
    {
        public string nombrePropiedad { get; set; }
        public decimal montoReserva { get; set; }
        public int semanaReserva { get; set; }
        public int añoReserva { get; set; }
        public string tipoReserva { get; set; }
        int idReserva;
        public ReservaFutura()
        {

        }
        public ReservaFutura(Propiedad propParam, decimal montoParam, int semanaParam, int añoParam, string tipoReservaParam, int idReservaParam)
        {
            this.nombrePropiedad = propParam.nombre;
            this.montoReserva = montoParam;
            this.semanaReserva = semanaParam;
            this.añoReserva = añoParam;
            this.tipoReserva = tipoReservaParam;
            this.idReserva = idReservaParam;
        }
    }
}
