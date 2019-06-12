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
                foreach (subasta s in sub)
                {
                    if (s.estaActiva())
                        subastasActivasListBox.DataSource = string.Format("Semana {0} año {1}", s.semana_de_subasta, Semanizador.semanaSegunFechaInicio(s.fecha_inicio, s.semana_de_subasta).Year);
                }
                if(subastasActivasListBox.ItemCount < 1) subastasActivasListBox.Text = "No hay subastas activas";
            }
            else subastasActivasListBox.Text = "No hay subastas activas";
        }

        private void reservaDirectaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere comfirmar la reserva?", "Reserva", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (Sesion.user.token > 0)
                {
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        ReservaDirecta re = new ReservaDirecta(this.propi.id, Sesion.user.mail, this.propi.montoReserva, int.Parse(reservaDirectaComboBox.SelectedItem.ToString().GetCharsBetween("Semana ", " de")));
                        conec.ReservaDirectas.Add(re);
                        conec.SaveChanges();
                    }
                    MessageBox.Show(string.Format("Se adjudico la reserva para la fecha {0}", Semanizador.semanaSegunFechaInicio(DateTime.Now, int.Parse(reservaDirectaComboBox.SelectedItem.ToString().GetCharsBetween("Semana ", " de"))).Date));
                    this.inicializar(this.propi);
                }
                else MessageBox.Show("No tiene suficientes creditos");
            }
            else
            {
                DialogResult resul = MessageBox.Show("Quiere cancelar la reserva?", "Reserva", MessageBoxButtons.OKCancel);
                if (resul == DialogResult.OK)
                {
                    MessageBox.Show("No se realizo la reserva");
                }
            }
        }
    }
}
