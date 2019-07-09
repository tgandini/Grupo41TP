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
using HSH_Desa_y_Test.ContextoDB;

namespace HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado_y_Deslogueado
{
    public partial class xucVistaPrincipalUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        public xucVistaPrincipalUsuario()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            Sesion.vistaPrincipalUserLogueado = this;
            this.ocultarFormsDerivados();
            this.xucListadoPropiedadesYEditar1.verificarBotonReservaDirecta();
        }
        internal void ocultarFormsDerivados()
        {
            foreach (Control control in this.panelControl1.Controls)
            {
                control.Visible = false;
                control.SendToBack();
            }
            this.xUCPerfilDeUsuario1.Visible = false;
            this.xUCPerfilDeUsuario1.SendToBack();
        }

        internal void renderizarListaPropiedades()
        {
            this.ocultarFormsDerivados();
            this.xucListadoPropiedadesYEditar1.Visible = true;
            this.xucListadoPropiedadesYEditar1.BringToFront();
            
        }

        internal void renderizarPerfilDeUsuario()
        {
            this.ocultarFormsDerivados();
            this.xUCPerfilDeUsuario1.inicializar();
            this.xUCPerfilDeUsuario1.Visible = true;
            this.xUCPerfilDeUsuario1.BringToFront();
        }

        public void inicializarPerfil()
        {
            this.xUCPerfilDeUsuario1.inicializar();
        }

        internal void renderizarListaSubastas()
        {
            this.ocultarFormsDerivados();
            this.xucListadoSubasta1.inicializar();
            this.xucListadoSubasta1.Visible = true;
            this.xucListadoSubasta1.BringToFront();
        }

        public void renderizarDetalleSubasta(subasta subastaActiva)
        {
            this.ocultarFormsDerivados();
            this.xUCDetalleSubasta1.inicializar(subastaActiva.id);
            this.xUCDetalleSubasta1.Visible = true;
            this.xUCDetalleSubasta1.BringToFront();
        }

    }
}
