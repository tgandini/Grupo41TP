using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class subasta
    {
        public subasta( int año, int semana, String monto, DateTime fechaInicio, int idDePropiedadParaSubastar)
        {
            this.semana_de_subasta = semana;
            this.monto_inicial = Convert.ToDecimal(monto);
            this.fecha_inicio = fechaInicio;
            this.fecha_fin = fechaInicio.AddDays(3);
            this.id_propiedad_subastada = idDePropiedadParaSubastar;
            this.añoReservado = año;
        }

        public void crear()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                conec.subastas.Add(this);
                conec.SaveChanges();
            }
        }

        public static List<subasta> llenarConSubasta()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.subastas.ToList();
            }
        }

        public static List<subasta> llenarConSubasta(int idProp)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.subastas.Where(p=> p.id_propiedad_subastada == idProp).ToList();
            }
        }

        public bool estaActiva()
        {
            return (this.fecha_inicio < DateTime.Now && this.fecha_fin > DateTime.Now);
        }
        
        public bool guardarEnBD()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                try
                {
                    conec.subastas.Add(this);
                    conec.SaveChanges();
                    return true;
                }
                catch
                {
                    MessageBox.Show("Hubo un error en el guardado de la base de datos");
                    return false;
                }
            }
        }
    }
}
