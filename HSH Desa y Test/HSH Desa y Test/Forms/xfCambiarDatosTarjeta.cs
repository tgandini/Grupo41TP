using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;
using System.Globalization;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfCambiarDatosTarjeta : DevExpress.XtraEditors.XtraForm
    {
        private tarjeta tt;
        public xfCambiarDatosTarjeta()
        {
            InitializeComponent();
        }

        public void agregarInicializar()
        {
            tituloControl.Text = "Agregar Tarjeta";
            nroTarjetaBox.ResetText();
            fechaVencimientoBox.ResetText();
            codSeguridadBox.ResetText();
        }

        public void modificarInicializar(tarjeta tar)
        {
            tt = tar;
            tituloControl.Text = "Modificar Tarjeta";
            nroTarjetaBox.Text = tar.numero;
            fechaVencimientoBox.Text = tar.vencimiento.ToString();
            codSeguridadBox.Text = tar.codigoSeguridad;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere agregar la tarjeta?", "Nueva Tarjeta", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if ((tarjeta.sacarGuiones(nroTarjetaBox.Text).Length == 16) && (fechaVencimientoBox.Text.Length > 0) && (codSeguridadBox.Text.Length == 3))
                {
                    if (tarjeta.ValidarFechaVencimiento(fechaVencimientoBox.Text))
                    {
                        tarjeta t = new tarjeta(nroTarjetaBox.Text, DateTime.ParseExact(fechaVencimientoBox.Text, "MM/yy", new CultureInfo("es-AR")), codSeguridadBox.Text, Sesion.user.mail);
                        if (tituloControl.Text.Equals("Modificar Tarjeta"))
                        {
                            if((tt.numero!=t.numero) || (tt.codigoSeguridad!=t.codigoSeguridad) || (tt.vencimiento != t.vencimiento))
                            {
                                tt.numero = t.numero; tt.vencimiento = t.vencimiento; tt.codigoSeguridad = t.codigoSeguridad;
                                using (ContextoEntity conec = new ContextoEntity())
                                {
                                    conec.Entry(tt).State = System.Data.Entity.EntityState.Modified;
                                    conec.SaveChanges();
                                }
                                MessageBox.Show("Se modifico la tarjeta");
                                this.Close();
                            }
                        }
                        else
                        {
                            using (ContextoEntity conec = new ContextoEntity())
                            {
                                conec.tarjetas.Add(t);
                                conec.SaveChanges();
                            }
                            MessageBox.Show("Se agrego la tarjeta");
                            this.Close();
                        }
                    }
                    else MessageBox.Show("La tarjeta ya venció");
                }
            }
        }
    }
}