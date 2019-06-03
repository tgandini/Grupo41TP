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
            nombreControl.Text = Sesion.user.nombre;
            apellidoControl.Text = Sesion.user.apellido;
            mailControl.Text = Sesion.user.mail;
            fechaNacimientoControl.Text = Sesion.user.fecha_nacimiento.ToString();
            tokenControl.Text = Sesion.user.token.ToString();
            tar = llenarConTarjetas(Sesion.user.mail);
            List<string> numT = new List<string>();
            foreach (tarjeta num in tar)
            {
                numT.Add(num.numero);
            }
            comboBox1.DataSource = numT;
            if(tar.Count > 1) eliminarTarjetaButton.Enabled = false;
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
            modificarUsuario.Show();
            this.inicializar();
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
                        conec.tarjetas.Remove(tar.Find(p => p.numero == comboBox1.SelectedText));
                        conec.SaveChanges();
                    }
                    this.inicializar();
                }
            }
            else MessageBox.Show("No se elimino debido a que solo tiene asociada una tarjeta");
        }

        private void agregarTarjetaButton_Click(object sender, EventArgs e)
        {
            xfCambiarDatosTarjeta m = new xfCambiarDatosTarjeta();
            m.agregarInicializar();
            m.Show();
            this.inicializar();
        }

        private void modificarTarjetaButton_Click(object sender, EventArgs e)
        {
            xfCambiarDatosTarjeta m = new xfCambiarDatosTarjeta();
            m.modificarInicializar(tar.Find(p => p.numero == comboBox1.SelectedText));
            m.Show();
            this.inicializar();
        }
    }
}
