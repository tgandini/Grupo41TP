using HSH_Desa_y_Test.Modelo_Expandido;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSH_Desa_y_Test.ContextoDB
{
    public partial class usuario
    {
        public usuario(string Pnombre, string Papellido, string Ppass, string Pmail, string PfechaNac)
        {
            this.nombre = Pnombre;
            this.apellido = Papellido;
            this.contraseña = Ppass;
            this.mail = Pmail;
            this.fecha_nacimiento = DateTime.Parse(PfechaNac);
            this.fecha_registro = DateTime.Today;
            this.premium = false;
            this.token = 2;
            this.tarjetas = new List<tarjeta>();
            this.usuarioParticipaEnSubastas = new List<usuarioParticipaEnSubasta>();

        }

        public static usuario traerDeDb(string mailParam, string mailPass)
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                if (!conexion.usuarios.Any(p => p.mail == mailParam))
                {
                    MessageBox.Show(string.Format("El mail {0} no se encuentra registrado", mailParam));
                    return null;
                }
                else
                {
                    var usuarioEnDB = conexion.usuarios.Where(p => p.mail == mailParam && p.contraseña == mailPass).FirstOrDefault();
                    if (usuarioEnDB != null)
                    {
                        MessageBox.Show(string.Format("Logueado como usuario: {0}", mailParam));
                        return usuarioEnDB;
                    }
                    else
                    {
                        MessageBox.Show("ERROR. Contraseña inválida");
                        return null;
                    }
                }
            }
        }
        public static Boolean validarMail(string mail)
        {
            var foo = new EmailAddressAttribute();
            return (foo.IsValid(mail));

        }

        public static Boolean existeMailEnBaseDeDatos(string mail)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var mailEnDB = conec.usuarios.Where(each => each.mail == mail).FirstOrDefault();
                return mailEnDB != null;
            }

        }

        public void restarCredito()
        {
            this.token--;
            using (ContextoEntity con = new ContextoEntity())
            {
                con.Entry(this).State = EntityState.Modified;
                con.SaveChanges();
            }
        }

        public void agregarCredito()
        {
            this.token++;
        }

        public static usuario getUsuarioFromId(string mailP)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.usuarios.Where(p => p.mail == mailP).FirstOrDefault();
            }
        }
        public List<ReservaFutura> ReservasFuturas
        {
            get
            {
                List<ReservaFutura> listaReservasParaDevolver = new List<ReservaFutura>();

                usuario usuarioConLasReservas;
                using (ContextoEntity conec = new ContextoEntity())
                {
                    usuarioConLasReservas = conec.usuarios
                          .Include("ReservaDirectas.Propiedad")
                          .Include("HotSales.Propiedad")
                          .Include("ganadorDeSubastas.subasta.Propiedad")
                          .Include("ganadorDeSubastas.usuarioParticipaEnSubasta")
                          .Where(p => p.mail == this.mail)
                      .First();
                }

                foreach (ReservaDirecta res in usuarioConLasReservas.ReservaDirectas)
                {
                    if (res.esFutura())
                    {
                        listaReservasParaDevolver.Add(new ReservaFutura(res.Propiedad, res.monto, res.semanaReservada, res.añoReservado, "Reserva Directa", res.id));
                    }
                }
                foreach (HotSale hts in usuarioConLasReservas.HotSales)
                {
                    if (hts.esFutura())
                    {
                        listaReservasParaDevolver.Add(new ReservaFutura(hts.Propiedad, hts.monto, hts.semanaReservada, hts.añoReservado, "Hot Sale", hts.id));
                    }
                }
                foreach (ganadorDeSubasta su in usuarioConLasReservas.ganadorDeSubastas)
                {
                    if (su.subasta.esFutura())
                    {
                        listaReservasParaDevolver.Add(new ReservaFutura(su.subasta.Propiedad, su.usuarioParticipaEnSubasta.monto, su.subasta.semana_de_subasta, su.subasta.añoReservado, "Subasta Ganada", su.id));
                    }
                }
                if (listaReservasParaDevolver != null) listaReservasParaDevolver = listaReservasParaDevolver.OrderBy(p => p.añoReserva).ThenBy(p => p.semanaReserva).ToList();
                return listaReservasParaDevolver;
            }
        }
    }
}
