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
        public ReservaDirecta(int idPro, string idUser, decimal precio, int semana)
        {
            this.id = int.MaxValue;
            this.idPropiedad = idPro;
            this.idUsuario = idUser;
            this.monto = precio;
            this.semanaReservada = semana;
            this.fechaReservada = Semanizador.semanaSegunFechaInicio(DateTime.Now, semana);
        }
        public ReservaDirecta()
        {

        }
    }
}
