using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class Propiedad
    {
        public Propiedad(string nombreProp, string ciudadProp, string provinciaProp, string paisProp, string tipoProp, string ubicacionProp, int cantHabitaciones,decimal montoReserva,string adminQueDioDeAlta, DateTime fechaAltaProp)
        {
            this.nombre = nombreProp;
            this.ciudad = ciudadProp;
            this.provincia = provinciaProp;
            this.pais = paisProp;
            this.tipo = tipoProp;
            this.ubicaciòn = ubicacionProp;
            this.habitaciones = cantHabitaciones;
            this.montoReserva = montoReserva;
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
                else if (this.existe()) //No se guarda la prop xq existe otra en la misma dirección y misma ciudad
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
        internal bool EstaLibre(int semana, int año, bool saltarMensajes)
        {
            Propiedad propDeDb;
            using (ContextoEntity conec = new ContextoEntity())
            {
                propDeDb = conec.Propiedads
                    .Include(a => a.ReservaDirectas)
                    .Include(a => a.HotSales)
                    .Include(a => a.subastas)
                    .Where(p => p.id == this.id).FirstOrDefault();
            }
            DateTime diaParaCheckear = Semanizador.LunesDeSemana(año, semana);
            if (propDeDb.ReservaDirectas.Any(p=> p.semanaReservada == semana && p.añoReservado==año))
            {
                if (saltarMensajes)MessageBox.Show(String.Format("La propiedad ya está reservada para la semana {0} del año {1}", semana, año), "La propiedad ya tiene una reserva");
                return false;
            }
            else if (propDeDb.subastas.Any(p=> p.semana_de_subasta== semana && p.añoReservado == año))
            {
                if (saltarMensajes) MessageBox.Show(String.Format("La propiedad ya tiene una subasta para la semana {0} del año {1}", semana, año), "La propiedad ya tiene una subasta");
                return false;
            }
            else if (propDeDb.HotSales.Any(p=> p.semanaReservada == semana && p.añoReservado == año))
            {
                if (saltarMensajes) MessageBox.Show(String.Format("La propiedad ya tiene una reserva directa para la semana {0} del año {1}", semana, año), "La propiedad ya tiene una reserva");
                return false;
            }

            return true;
        }

        public List<string> semanasDisponibles()
        {
            int primeraSemana = Semanizador.getSemanaDelAño(DateTime.Now.AddMonths(6));
            int ultimaSemana = Semanizador.getSemanaDelAño(DateTime.Now.AddMonths(12));
            List<string> st = new List<string>();
            int i;
            if (primeraSemana >= ultimaSemana)
            {
                for (i = primeraSemana; i <= 52; i++)
                {
                    if (this.EstaLibre(i, DateTime.Now.Year, false))
                    {
                        string aux = Semanizador.LunesDeSemana(DateTime.Now.Year, i).ToString("dd/MM/yyyy");
                        st.Add(aux);
                    }
                }
                for (i = 1; i <= ultimaSemana; i++)
                {
                    if (this.EstaLibre(i, DateTime.Now.Year + 1, false))
                    {
                        string aux = Semanizador.LunesDeSemana(DateTime.Now.Year + 1, i).ToString("dd/MM/yyyy");
                        st.Add(aux);
                    }
                }
            }
            else
            {
                if (Semanizador.getSemanaDelAño(DateTime.Now) < primeraSemana)
                {
                    for (i = primeraSemana; i <= ultimaSemana; i++)
                    {
                        if (this.EstaLibre(i, DateTime.Now.Year, false))
                        {
                            string aux = Semanizador.LunesDeSemana(DateTime.Now.Year, i).ToString("dd/MM/yyyy");
                            st.Add(aux);
                        }
                    }
                }
                else
                {
                    for (i = primeraSemana; i <= ultimaSemana; i++)
                    {
                        if (this.EstaLibre(i, DateTime.Now.Year + 1, false))
                        {
                            string aux = Semanizador.LunesDeSemana(DateTime.Now.Year + 1, i).ToString("dd/MM/yyyy");
                            st.Add(aux);
                        }
                    }
                }
            }
            return st;
        }
        public bool actualizarPropiedadEnBd()
        {
            try
            {
                using (ContextoEntity conexion = new ContextoEntity())
                {
                    conexion.Entry<Propiedad>(this).State= EntityState.Modified;
                    conexion.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool existe()
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                return conexion.Propiedads.Any(p => p.ubicaciòn == this.ubicaciòn && p.ciudad == this.ciudad && p.provincia == this.provincia && p.pais == this.pais);
            }
        }
    }
}
