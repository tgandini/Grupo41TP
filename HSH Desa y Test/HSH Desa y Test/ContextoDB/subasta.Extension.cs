using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class subasta
    {
        public subasta(Propiedad propiedad, int semana, String monto, DateTime fechaInicio)
        {
            this.semana_de_subasta = semana;
            this.monto_inicial = Convert.ToDecimal(monto);
            this.id_propiedad_subastada = propiedad.id;
            this.fecha_inicio = fechaInicio;
            this.fecha_fin = fechaInicio.AddDays(3);
            this.id = int.MaxValue;
            propiedad.subastas.Add(this);
        }

        public void crear()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                conec.subastas.Add(this);
            }
        }
    }
}
