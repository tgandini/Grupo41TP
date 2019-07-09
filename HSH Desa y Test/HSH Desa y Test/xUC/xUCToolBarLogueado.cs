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
using HSH_Desa_y_Test.Forms;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCToolBarLogueado : DevExpress.XtraEditors.XtraUserControl
    {

        public xUCToolBarLogueado()
        {
            InitializeComponent();
        }
        public xUCToolBarLogueado(bool logueoComoAdmin)
        {
            InitializeComponent();
            if (Sesion.admin != null)
            {
                cambiarTarifasButton.Visible = true;
                Admin.Visible = true;
            }
            else
            {
                Admin.Visible = false;
                cambiarTarifasButton.Visible = false;
            }
            if (Sesion.user != null)
            {                
                labelUserLogueado.Text = labelUserLogueado.Text + Sesion.user.nombre + " " + Sesion.user.apellido;
            }
            else
            {                
                labelUserLogueado.Text = "Usuario Logueado: Administrador";
            }
        }



        #region Cargar labels

        internal void CargarLabelConUsuario()
        {
            this.labelUserLogueado.Text = string.Format("Usuario logueado: {0}", Sesion.user.mail);
            this.Admin.Visible = false;
        }

        internal void CargarLabelConAdmin()
        {
            this.labelUserLogueado.Text = string.Format("Logueado como Administrador");
            this.Admin.Visible = true;

        }
        #endregion


        #region eventos de click
        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar Sesion?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Sesion.user = null;
                Sesion.vistaPrincipalUserLogueado.ocultarFormsDerivados();
                Sesion.getVistaPrincipal().instanciarSinUsuarioLogueado();
            }
            else if (result == DialogResult.No)
            {
            }

        }

        private void Admin_Click(object sender, EventArgs e)
        {
            new xfCrearAdmin().Show();
        }

        #endregion

        private void ClickAcercaNosotros(object sender, EventArgs e)
        {
            new xfPantallaContacto().ShowDialog();
        }

        private void cambiarTarifasButton_Click(object sender, EventArgs e)
        {
            xfCambiarMontoSuscripcion ms = new xfCambiarMontoSuscripcion();
            ms.inicializar();
            ms.Show();
        }
    }
}
