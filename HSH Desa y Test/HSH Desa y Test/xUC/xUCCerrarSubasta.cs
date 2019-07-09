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
using HSH_Desa_y_Test.ContextoDB;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCCerrarSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        private List<subasta> subi;
        private subasta s;
        List<subasta> iden;
        public xUCCerrarSubasta()
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
            this.limpiar();
            subi = subasta.llenarConSubasta();
            iden = new List<subasta>();
            foreach (subasta s in subi)
            {
                if (s.estaActiva()) iden.Add(s);
            }
            subastaSource.DataSource = iden;
            gridControl1.DataSource = subastaSource.DataSource;
            gridControl1.Update();
            gridView1.OptionsBehavior.Editable = false;
        }



        private void subastaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Propiedad po;
            usuarioParticipaEnSubasta usp;
            s = (subasta)gridView1.GetFocusedRow();
            if (s != null)
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    po = conec.Propiedads.Where(p => p.id == s.id_propiedad_subastada).First();
                    usp = conec.usuarioParticipaEnSubastas.Where(p => p.idSubasta == s.id).OrderByDescending(p => p.monto).ToList().FirstOrDefault();
                }
                ubicacionBox.Text = po.ubicaciòn;
                NombreBox.Text = po.nombre;
                ciudadBox.Text = po.ciudad;
                provinciaBox.Text = po.provincia;
                paisBox.Text = po.pais;
                if (usp != null) montoBox.Text = usp.monto.ToString();
                else montoBox.Text = s.monto_inicial.ToString();
            }
        }


        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                DialogResult m = MessageBox.Show("Desea cerrar la subasta?", "Cerrar Subasta", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    s = (subasta)gridView1.GetFocusedRow();
                    s.fecha_fin = DateTime.Today;
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        var su = conec.subastas.Where(p => p.id == s.id).First();
                        DbEntityEntry<subasta> ee = conec.Entry(su);
                        ee.CurrentValues.SetValues(s);
                        su.cerrar();
                        conec.SaveChanges();
                    }
                    this.inicializar();

                }
            }
        }

        private void limpiar()
        {
            ubicacionBox.Text = "";
            montoBox.Text = "";
            NombreBox.Text = "";
            ciudadBox.Text = "";
        }

    }
}
