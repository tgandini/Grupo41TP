using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCOperacionesPropiedadesUsuarioLogueado : DevExpress.XtraEditors.XtraUserControl
    {
        private Propiedad propi;
        List<subasta> subActivas = new List<subasta>();
        public xUCOperacionesPropiedadesUsuarioLogueado()
        {
            InitializeComponent();
        }

        public void inicializar(Propiedad pro)
        {
            this.propi = pro;
            if (Sesion.user.premium)
            {
                reservaDirectaButton.Visible = true;
                reservaDirectaComboBox.Visible = true;
                reservaDirectaLabel.Visible = true;
                reservaDirectaButton.Enabled = true;
                reservaDirectaComboBox.DataSource = pro.semanasDisponibles();
                precioReservaDirectaLabel.Enabled = true;
                montoReservaDirectaLabel.Enabled = true;
                montoReservaDirectaLabel.Text = pro.montoReserva.ToString();
            }
            else
            {
                reservaDirectaButton.Visible = false;
                reservaDirectaComboBox.Visible = false;
                reservaDirectaLabel.Visible = false;
                reservaDirectaButton.Enabled = false;
                precioReservaDirectaLabel.Visible = false;
                montoReservaDirectaLabel.Visible = false;
            }
            var sub = subasta.llenarConSubasta(pro.id);
            if (sub != null)
            {
                List<string> subastasActivas = new List<string>();
                foreach (subasta s in sub)
                {
                    if (s.estaActiva())
                    {
                        subastasActivas.Add(string.Format(Semanizador.LunesDeSemana(Semanizador.semanaSegunFechaInicio(s.fecha_inicio, s.semana_de_subasta).Year, s.semana_de_subasta).ToString("dd/MM/yyyy")));
                        subActivas.Add(s);
                    }
                }
                subastasActivasListBox.DataSource = subastasActivas;
                if (subastasActivasListBox.ItemCount < 1) subastasActivasListBox.Text = "No hay subastas activas";
            }
            else subastasActivasListBox.Text = "No hay subastas activas";
        }

        private void reservaDirectaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere confirmar la reserva?", "Reserva", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Sesion.user.token > 0)
                {
                    DateTime semanaAReservar = DateTime.Parse(reservaDirectaComboBox.SelectedItem.ToString());
                    if (this.propi.EstaLibre(Semanizador.getSemanaDelAño(semanaAReservar), semanaAReservar.Year, true))
                    {
                        using (ContextoEntity conec = new ContextoEntity())
                        {
                            ReservaDirecta re = new ReservaDirecta(this.propi.id, Sesion.user.mail, this.propi.montoReserva, Semanizador.getSemanaDelAño(semanaAReservar), semanaAReservar.Year);
                            conec.ReservaDirectas.Add(re);
                            conec.SaveChanges();
                            Sesion.user.restarCredito();
                        }
                        MessageBox.Show(string.Format("Se adjudico la reserva para la fecha {0}", semanaAReservar.ToString("dd/MM/yyyy")));
                        this.inicializar(this.propi);
                    }
                }
                else MessageBox.Show("No tiene suficientes creditos");
            }
            else
            {
                DialogResult resul = MessageBox.Show("Quiere cancelar la operacion?", "Reserva", MessageBoxButtons.OKCancel);
                if (resul == DialogResult.OK)
                {
                    MessageBox.Show("No se realizo la operacion de reserva");
                }
            }
        }

        private void linkSubastaButton_Click(object sender, EventArgs e)
        {
            if (subastasActivasListBox.SelectedIndex != -1)
            {
                Sesion.vistaPrincipalUserLogueado.renderizarDetalleSubasta(subActivas.ElementAt(subastasActivasListBox.SelectedIndex));
            }
            else MessageBox.Show("No se seleccionó ninguna subasta para mostrar");
        }
    }
}
