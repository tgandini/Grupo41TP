using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado;
using HSH_Desa_y_Test.Modelo_Expandido;

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

        public static ReservaDirecta getOneById(int idP)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.ReservaDirectas
                    .Include(a => a.usuario)
                    .Where(p => p.id == idP).First();
            }
        }

        public void cancelarGanador(xucReservasFuturas UcQueLoLlama)
        {
            try
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    if (Semanizador.LunesDeSemana(this.añoReservado, this.semanaReservada) >= DateTime.Now.AddMonths(6))
                    {
                        this.usuario.agregarCredito();
                        conec.Entry(this.usuario).State = System.Data.Entity.EntityState.Modified;
                    }
                    conec.ReservaDirectas.Remove(this);
                    conec.SaveChanges();
                    UcQueLoLlama.inicializar();
                    MessageBox.Show("Se canceló la reserva con éxito");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
