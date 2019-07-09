using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class HotSale
    {
        public HotSale(DateTime inicio, DateTime fin, decimal precio, int semana, int año, Propiedad prop)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = precio;
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.idUsuario = null;
            this.Propiedad = prop;
            this.idPropiedad = prop.id;
        }

        public HotSale(DateTime inicio, DateTime fin, decimal precio, int semana, int año, Propiedad prop, usuario user)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = precio;
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.usuario = user;
            this.idUsuario = user.mail;
            this.Propiedad = prop;
            this.idPropiedad = prop.id;
        }

        public HotSale()
        {

        }
    }
}
