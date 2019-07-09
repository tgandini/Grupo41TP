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
using HSH_Desa_y_Test.Modelo_Expandido;
using HSH_Desa_y_Test.Forms;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xucComandosAdmin : DevExpress.XtraEditors.XtraUserControl
    {
        public xucComandosAdmin()
        {
            
            InitializeComponent();
        }

        private void btnAltaPropiedad_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarAltaPropiedad();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarModificacionYBajaPropiedad();
        }

        private void altaUsuarioButton_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarAltaUsuario();
        }

        private void modificarBajaButton_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarModificacionYBajaUsuario();
        }

        private void crearSubastaBtn_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarAltaSubasta();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            xfCambiarMontoSuscripcion ms = new xfCambiarMontoSuscripcion();
            ms.inicializar();
            ms.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarCerrarSubasta();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.renderizarCrearHotSale();
        }
    }
}
