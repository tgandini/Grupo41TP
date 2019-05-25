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
using HSH_Desa_y_Test.xUC;
using HSH_Desa_y_Test.Modelo_Expandido;
using DevExpress.XtraLayout;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfPantallaPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public xfPantallaPrincipal()
        {
            InitializeComponent();
            this.inicializar();
                  

        }

        private void inicializar()
        {
            this.WindowState = FormWindowState.Maximized;
            Sesion.guardarPantallaPrincipal(this);     
            this.instanciarSinUsuarioLogueado();
            //Desactivo y mando para atrás las vistas de user logueado y admin
            this.xucVistaPrincipalAdmin1.Visible = false;
            this.xucVistaPrincipalAdmin1.SendToBack();
            this.xucVistaPrincipalAdmin1.inicializar();
        }


        public void instanciarSinUsuarioLogueado()
        {
            this.desactivarTodosLosControlesDePanel();
            //mando el toolbar de logueado atrás
            this.xUCToolBarLogueado1.Visible = false;
            this.xUCToolBarLogueado1.SendToBack();

            //traigo el toolbar de deslogueado
            this.xUCtoolbardeslogueado1.Visible = true;
            this.xUCToolBarLogueado1.BringToFront();
        }

        private void desactivarTodosLosControlesDePanel()
        {
            foreach (Control c in this.panelControl1.Controls)
            {
                c.Visible = false;
                c.SendToBack();
            }
        }

        internal void renderizarConUsuario()
        {
          // oculto y mando para atrás la toolbar de deslogueado
            this.xUCtoolbardeslogueado1.Visible = false;
            this.xUCToolBarLogueado1.SendToBack();

            //cargo con datos la toolbar de logueado y la traigo al frente
            this.xUCToolBarLogueado1.CargarLabelConUsuario();
            this.xUCToolBarLogueado1.Visible = true;
            this.xUCToolBarLogueado1.BringToFront();

            //traigo el futuro panel de user logueado
            this.xucListadoPropiedadesYEditar1.CargarDatos();
            this.xucListadoPropiedadesYEditar1.Visible = true;
            this.xucListadoPropiedadesYEditar1.BringToFront();
        }

        internal void renderizarConAdmin()
        {

            //Escondo la toolbar de user deslogueado
            this.xUCtoolbardeslogueado1.Visible = false;
            this.xUCToolBarLogueado1.SendToBack();

            //Configuro la toolbar de User Logueado y la traigo al frente
            this.xUCToolBarLogueado1.CargarLabelConAdmin();
            this.xUCToolBarLogueado1.Visible = true;
            this.xUCToolBarLogueado1.BringToFront();

            //traigo al frente la vista principal del administrador
            this.xucVistaPrincipalAdmin1.Visible = true;
            this.xucVistaPrincipalAdmin1.BringToFront();
        }
    }
    
}
