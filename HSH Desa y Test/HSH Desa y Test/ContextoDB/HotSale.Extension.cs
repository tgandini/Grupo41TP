using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class HotSale
    {
        public int getId()
        {
            return this.id;
        }
        public HotSale(DateTime inicio, DateTime fin, decimal precio, int semana, int año, Propiedad prop)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = precio;
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.idUsuario = null;
            this.idPropiedad = prop.id;
            using (ContextoEntity conec = new ContextoEntity())
            {
                this.Propiedad = conec.Propiedads.Where(p => p.id == prop.id).First();
            }
        }

        public HotSale(DateTime inicio, DateTime fin, decimal precio, int semana, int año, Propiedad prop, usuario user)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = precio;
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.idUsuario = user.mail;
            using (ContextoEntity conec = new ContextoEntity())
            {
                this.Propiedad = conec.Propiedads.Where(p => p.id == prop.id).First();
                this.usuario = conec.usuarios.Where(p => p.mail == user.mail).First();
            }
            this.idPropiedad = prop.id;
        }

        public HotSale()
        {

        }

        public static List<HotSale> traerDeDB()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.HotSales.ToList();
            }
        }
        public bool esFutura()
        {
            if (this.añoReservado > DateTime.Today.Year) return true;
            else if (this.añoReservado == DateTime.Today.Year && this.semanaReservada > Semanizador.getSemanaDelAño(DateTime.Today)) return true;
            else return false;
        }
    }
}
