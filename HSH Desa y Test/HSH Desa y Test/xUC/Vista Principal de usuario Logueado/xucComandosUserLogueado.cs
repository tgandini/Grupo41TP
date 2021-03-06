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

namespace HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado_y_Deslogueado
{
    public partial class xucComandosUserLogueado : DevExpress.XtraEditors.XtraUserControl
    {
        public xucComandosUserLogueado()
        {
            InitializeComponent();
        }

        private void btnAltaPropiedad_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalUserLogueado.renderizarListaPropiedades();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalUserLogueado.renderizarPerfilDeUsuario();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalUserLogueado.renderizarListaSubastas();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalUserLogueado.renderizarListaHotSale();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalUserLogueado.renderizarListaReservasFuturas();
        }
    }
}
