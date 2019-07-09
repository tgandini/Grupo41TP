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

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCListadoHotSale : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCListadoHotSale()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            HSH_Desa_y_Test.ContextoDB.ContextoEntity dbContext = new HSH_Desa_y_Test.ContextoDB.ContextoEntity();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.HotSales.LoadAsync().ContinueWith(loadTask =>
            {
    // Bind data to control when loading complete
    gridControl1.DataSource = dbContext.HotSales.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        public void inicializar()
        {
            List<HotSale> hot = HotSale.traerDeDB();
            List<HotSale> ok= new List<HotSale>();
            foreach(HotSale r in hot)
            {
                if (r.fechaInicio >= DateTime.Now && r.fechaFin < DateTime.Now && r.idUsuario==null) ok.Add(r);
            }
            gridControl1.DataSource = ok;
            if (gridView1.RowCount > 0)
            {
                xUCDetalleHotsale1.Visible = true;
                HotSale h = (HotSale)gridView1.GetFocusedRow();
                Propiedad prop;
                using (ContextoEntity conec = new ContextoEntity())
                {
                    prop = conec.Propiedads.Where(p => p.id == h.idPropiedad).First();
                }
                xUCDetalleHotsale1.inicializar(h, prop);
            }
            else xUCDetalleHotsale1.Visible = false;
        }
    }
}