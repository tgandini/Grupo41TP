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

namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    public partial class xucVistaPrincipalAdmin : DevExpress.XtraEditors.XtraUserControl
    {
        public xucVistaPrincipalAdmin()
        {
            InitializeComponent();
            
        }

        public void inicializar()
        {
            Sesion.vistaPrincipalDeAdmin = this;
            this.ocultarFormsderivados();
        }

        internal void renderizarAltaPropiedad()
        {
            this.ocultarFormsderivados();
            this.xfDarDeAltaPropiedad1.Visible = true;
            this.xfDarDeAltaPropiedad1.BringToFront();
        }

        internal void renderizarModificacionYBajaPropiedad()
        {
            this.ocultarFormsderivados();
            this.xfDarDeBajaPropiedad2.inicializar();
            this.xfDarDeBajaPropiedad2.Visible = true;
            this.xfDarDeBajaPropiedad2.BringToFront();
        }

        internal void renderizarAltaUsuario()
        {
            this.ocultarFormsderivados();
            this.xfRegistrarceForm1.SetearTexto("Dar de alta");
            this.xfRegistrarceForm1.Visible = true;
            this.xfRegistrarceForm1.BringToFront();

        }

        internal void renderizarModificacionYBajaUsuario()
        {
            this.ocultarFormsderivados();
            this.xfDarDeBajaUsuario1.inicializar();
            this.xfDarDeBajaUsuario1.Visible = true;
            this.xfDarDeBajaUsuario1.BringToFront();
        }

        internal void renderizarAltaSubasta()
        {
            this.ocultarFormsderivados();
            this.xfAltaSubasta1.inicializar();
            this.xfAltaSubasta1.Visible = true;
            this.xfAltaSubasta1.BringToFront();
        }

        internal void renderizarCerrarSubasta()
        {
            this.ocultarFormsderivados();
            this.xUCCerrarSubasta1.inicializar();
            this.xUCCerrarSubasta1.Visible = true;
            this.xUCCerrarSubasta1.BringToFront();
        }

        internal void renderizarCrearHotSale()
        {
            this.ocultarFormsderivados();
            this.xUCCrearHotsale1.inicializar();
            this.xUCCrearHotsale1.Visible = true;
            this.xUCCrearHotsale1.BringToFront();
        }

        internal void ocultarFormsderivados()
        {
            foreach (Control control in this.panelControl1.Controls)
            {
                control.Visible = false;
                control.SendToBack();
               
            }
            
        }

        internal void vuelveDeModificarUsuario()
        {
            this.xfDarDeBajaUsuario1.vuelveDeModificar();
        }

        internal void vuelveDeModificarPropiedad()
        {
            this.xfDarDeBajaPropiedad2.vuelveDeModificar();
        }

        internal void renderizarListadoHotSales()
        {
            this.ocultarFormsderivados();
            this.xUCListadoHotSale1.inicializarAdmin();
            this.xUCListadoHotSale1.Visible = true;
            this.xUCListadoHotSale1.BringToFront();
        }
    }
}
