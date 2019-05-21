﻿using System;
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
            this.inicializar();
        }

        private void inicializar()
        {
            Sesion.vistaPrincipalDeAdmin = this;
            this.ocultarFormsderivados();
            this.xfDarDeBajaPropiedad1.inicializar();
            
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
            this.xfDarDeBajaPropiedad1.Visible = true;
            this.xfDarDeBajaPropiedad1.BringToFront();
        }

        internal void renderizarAltaUsuario()
        {
            this.ocultarFormsderivados();
        }

        internal void renderizarModificacionYBajaUsuario()
        {
            this.ocultarFormsderivados();
        }

        internal void ocultarFormsderivados()
        {
            foreach (Control control in this.panelControl1.Controls)
            {
                control.Visible = false;
                control.SendToBack();
               
            }
            
        }
    }
}
