using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class ReservaDirecta
    {
        public int getId()
        {
            return this.id;
        }

        public ReservaDirecta(int idPro, string idUser, decimal precio, int semana, int yeara)
        {
            this.id = int.MaxValue;
            this.idPropiedad = idPro;
            this.idUsuario = idUser;
            this.monto = precio;
            this.semanaReservada = semana;
            this.fechaReservada = DateTime.Now;
            this.añoReservado = yeara;
        }
        public ReservaDirecta()
        {

        }
        public bool esFutura()
        {
            if (this.añoReservado > DateTime.Today.Year) return true;
            else if (this.añoReservado == DateTime.Today.Year && this.semanaReservada > Semanizador.getSemanaDelAño(DateTime.Today)) return true;
            else return false;
        }

    }
}
