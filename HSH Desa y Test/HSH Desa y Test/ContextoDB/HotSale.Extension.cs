using HSH_Desa_y_Test.Modelo_Expandido;
using HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class HotSale
    {
        public int getId()
        {
            return this.id;
        }        public HotSale(DateTime inicio, DateTime fin, string precio, int semana, int año, Propiedad prop)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = decimal.Parse(precio);
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.idUsuario = null;
            this.idPropiedad = prop.id;
        }

        public HotSale(DateTime inicio, DateTime fin, string precio, int semana, int año, Propiedad prop, usuario user)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.monto = decimal.Parse(precio);
            this.semanaReservada = semana;
            this.añoReservado = año;
            this.id = int.MaxValue;
            this.idUsuario = user.mail;
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

        public static List<HotSale> traerDeDB(int proid)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.HotSales.Where(p=> p.idPropiedad == proid).ToList();
            }
        }

        public static HotSale getOneById(int idP)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.HotSales.Where(p=>p.id== idP).First();
            }
        }
        public bool esFutura()
        {
            if (this.añoReservado > DateTime.Today.Year) return true;
            else if (this.añoReservado == DateTime.Today.Year && this.semanaReservada > Semanizador.getSemanaDelAño(DateTime.Today)) return true;
            else return false;
        }

        public bool guardarEnBD()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                try
                {
                    conec.HotSales.Add(this);
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
        public void cancelarGanador(xucReservasFuturas UcQueLoLlama)
        {
            try
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    this.idUsuario = null;
                    conec.Entry(this).State = System.Data.Entity.EntityState.Modified;
                    conec.SaveChanges();
                    UcQueLoLlama.inicializar();
                    MessageBox.Show("Se canceló el hotsale con éxito");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
                
        }
    }
}
