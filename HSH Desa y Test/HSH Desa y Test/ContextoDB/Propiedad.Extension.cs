using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class Propiedad
    {
        public Propiedad(string nombreProp, string ciudadProp, string tipoProp, string ubicacionProp, int cantHabitaciones, string adminQueDioDeAlta, DateTime fechaAltaProp)
        {
            this.nombre = nombreProp;
            this.ciudad = ciudadProp;
            this.tipo = tipoProp;
            this.ubicaciòn = ubicacionProp;
            this.habitaciones = cantHabitaciones;
            this.adminQueDioDeAltaProp = adminQueDioDeAlta;
            this.fechaAlta = fechaAltaProp;
            this.id = int.MaxValue;
            this.fotos = new List<foto>();
        }


  

        internal bool guardarAltaEnBD()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                if (conec.Propiedads.Any(p => p.nombre == this.nombre)) //no se guarda la propiedad xq existe otra con el mismo nombre

                {
                    MessageBox.Show("Error. Ya existe una propiedad con ese nombre");
                    return false;
                }
                else if (conec.Propiedads.Any(p=> p.ubicaciòn == this.ubicaciòn && p.ciudad==this.ciudad )) //No se guarda la prop xq existe otra en la misma dirección y misma ciudad
                {
                    MessageBox.Show("Error. Ya existe una propiedad en esa dirección");
                    return false;
                }
                else
                {
                    try
                    {
                        conec.Propiedads.Add(this);
                        conec.SaveChanges();
                        return true;
                    }
                    catch
                    {
                        MessageBox.Show("Ocurrió un error en el guardado de datos");
                        return false;
                    }
                    
                }                                    
            }

        }
        internal bool estaLibre(int semana, int año)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                if (conec.subastas.Any(p => p.id_propiedad_subastada == this.id && p.fecha_inicio == Semanizador.LunesDeSemana(año, semana))) return false;
                if (conec.HotSales.Any(p => p.idPropiedad == this.id && p.fechaInicio == Semanizador.LunesDeSemana(año, semana))) return false;
                if (conec.ReservaDirectas.Any(p => p.idPropiedad == this.id && p.fechaReservada == Semanizador.LunesDeSemana(año, semana))) return false;
                else return true;
            }
        }


    }
}
