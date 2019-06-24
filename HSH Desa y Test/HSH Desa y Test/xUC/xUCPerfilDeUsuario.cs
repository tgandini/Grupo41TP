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
using HSH_Desa_y_Test.Forms;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCPerfilDeUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        List<tarjeta> tar;
        public xUCPerfilDeUsuario()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            if (!Sesion.hayUserLogueado()) Sesion.user = new usuario();
            if (Sesion.user.premium == true) simpleButton1.Visible = false;
            else simpleButton1.Visible = true;
            nombreControl.Text = Sesion.user.nombre;
            apellidoControl.Text = Sesion.user.apellido;
            mailControl.Text = Sesion.user.mail;
            fechaNacimientoControl.Text = Sesion.user.fecha_nacimiento.Date.ToString("dd/MM/yyyy");
            tokenControl.Text = Sesion.user.token.ToString();
            fechaRegistroControl.Text = Sesion.user.fecha_registro.Date.ToString("dd/MM/yyyy");
            tar = llenarConTarjetas(Sesion.user.mail);
            List<string> numT = new List<string>();
            foreach (tarjeta num in tar)
            {
                numT.Add(num.numero);
            }
            comboBox1.DataSource = numT;
            if (tar.Count < 1) eliminarTarjetaButton.Enabled = false;
            else eliminarTarjetaButton.Enabled = true;
        }

        private List<tarjeta> llenarConTarjetas(string idenUsuario)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {

                return conec.tarjetas.Where(p => p.idPersona == idenUsuario).ToList();

            }
        }

        private void modificarPerfilButton_Click(object sender, EventArgs e)
        {
            usuario usuarioAModificar = Sesion.user;
            xUC.xUCModificarDatosUsuario modificarUsuario = new xUC.xUCModificarDatosUsuario(usuarioAModificar.mail);
            modificarUsuario.seModificoUsuario += this.inicializar;
            modificarUsuario.Show();
        }

        private void eliminarTarjetaButton_Click(object sender, EventArgs e)
        {
            if (tar.Count > 1)
            {
                DialogResult result = MessageBox.Show("Quiere eliminar la tarjeta?", "Eliminar", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        conec.tarjetas.Remove(conec.tarjetas.Where(p => p.numero == comboBox1.SelectedItem.ToString()).First());
                        conec.SaveChanges();
                    }
                    this.inicializar();
                }
                MessageBox.Show("Se eliminó la tarjeta con éxito");
            }
            else MessageBox.Show("No se elimino debido a que solo tiene asociada una tarjeta");
        }

        private void agregarTarjetaButton_Click(object sender, EventArgs e)
        {
            xfCambiarDatosTarjeta m = new xfCambiarDatosTarjeta();
            m.agregarInicializar();
            m.Show();
        }

        private void modificarTarjetaButton_Click(object sender, EventArgs e)
        {
            xfCambiarDatosTarjeta m = new xfCambiarDatosTarjeta();
            m.modificarInicializar(tar.Find(p => p.numero == comboBox1.SelectedValue.ToString()));
            m.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            xfQuieroSerPremium q = new xfQuieroSerPremium();
            q.Show();
        }
    }
}
