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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xucListadoSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        public xucListadoSubasta()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            HSH_Desa_y_Test.ContextoDB.ContextoEntity dbContext = new HSH_Desa_y_Test.ContextoDB.ContextoEntity();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.subastas.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.subastas.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void inicializar()
        {
            gridControl1.DataSource = this.traerSubastasBD();
            subasta sus = (subasta)gridView1.GetFocusedRow();
            this.xUCDetalleSubasta1.inicializar(sus.id);
        }

        public List<subasta> traerSubastasBD()
        {
            List<subasta> s;
            using (ContextoEntity conec = new ContextoEntity())
            {
                s = conec.subastas.ToList();
            }
            if (s != null)
            {
                foreach (subasta su in s)
                {
                    if (su.estaActiva())
                    {
                        s.Remove(su);
                    }
                }
            }
            return s;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRow() != null && Sesion.user != null)
            {
                int idProp = ((subasta)gridView1.GetFocusedRow()).id;
                xUCDetalleSubasta1.inicializar(idProp);
            }

        }
    }
}
