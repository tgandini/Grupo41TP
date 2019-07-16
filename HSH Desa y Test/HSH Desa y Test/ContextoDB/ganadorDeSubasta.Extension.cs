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
    public partial class ganadorDeSubasta
    {
        public ganadorDeSubasta()
        {
        }
        public ganadorDeSubasta(string mailUsuarioP, int idSubastaP, int idPujaEnSubastaP)
        {
            this.idUsuario = mailUsuarioP;
            this.idSubasta = idSubastaP;
            this.idPujaEnSubasta = idPujaEnSubastaP;
        }

        public static ganadorDeSubasta getOneById(int idP)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.ganadorDeSubastas
                    .Include(a=> a.usuario)
                    .Include(a=> a.subasta)
                    .Where(p => p.id == idP).First();
            }
        }

        public void cancelarGanador(xucReservasFuturas UcQueLoLlama)
        {
            try
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    if (Semanizador.LunesDeSemana(this.subasta.añoReservado, this.subasta.semana_de_subasta) >= DateTime.Now.AddMonths(6))
                    {
                        this.usuario.agregarCredito();
                        conec.Entry(this.usuario).State = System.Data.Entity.EntityState.Modified;
                    }
                    conec.ganadorDeSubastas.Remove(this);
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
