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
using System.Data.Entity;
using HSH_Desa_y_Test.ContextoDB;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    public partial class xucListadoPropiedadesYEditar : DevExpress.XtraEditors.XtraUserControl
    {
        private ContextoEntity contexto = new ContextoEntity();
        public xucListadoPropiedadesYEditar()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            HSH_Desa_y_Test.ContextoDB.ContextoEntity dbContext = new HSH_Desa_y_Test.ContextoDB.ContextoEntity();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Propiedads.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.Propiedads.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        
        public void CargarDatos()
        {
            bindingPropiedad.DataSource = traerPropiedadesDeDb();            
            gridView1.SelectRow(3);
        }

        private object traerPropiedadesDeDb()
        {
            
                return contexto.Propiedads.OrderBy(p => p.id).ToList();
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRow() != null && Sesion.user != null)
            {
                int idProp = ((Propiedad)gridView1.GetFocusedRow()).id;
                xUCDetallePropiedad1.inicializar(idProp);
                this.xUCOperacionesPropiedadesUsuarioLogueado1.inicializar((Propiedad)gridView1.GetFocusedRow());
            }
   
        }

        private void xucListadoPropiedadesYEditar_Load(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null && Sesion.user != null)
            {
                int idProp = ((Propiedad)gridView1.GetFocusedRow()).id;
                xUCDetallePropiedad1.inicializar(idProp);
                this.xUCOperacionesPropiedadesUsuarioLogueado1.inicializar((Propiedad)gridView1.GetFocusedRow());
            }
        }
    }
}
