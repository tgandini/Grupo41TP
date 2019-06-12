﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HSH_Desa_y_Test.ContextoDB;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaPropiedad : DevExpress.XtraEditors.XtraUserControl
    {
        private List<byte[]> foto=null;
        public xfDarDeBajaPropiedad()
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

        public void inicializar()
        {
            bindingSource1.DataSource = llenarTablaConPropiedades();
            gridView1.OptionsBehavior.Editable = false;

            if (bindingSource1.Count >= 1)
            {
                noHayPropiedades.Visible = false;
                gridView1.Columns.ColumnByFieldName("id").OptionsColumn.AllowEdit = false;
                simpleButton2.Enabled = true;
                simpleButton1.Enabled = true;
            }
            else
            {
                noHayPropiedades.Visible = true;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
                foto = null;
            }
        }

        private List<Propiedad> llenarTablaConPropiedades()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.Propiedads.ToList();
            }
        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            Propiedad propiedadSeleccionado = (Propiedad)gridView1.GetFocusedRow();
            string st = string.Concat("Seguro que desea Borrar la propiedad ", propiedadSeleccionado.id, "?");
            DialogResult result = MessageBox.Show(st, "Salir", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    var propiedadaborrar = conec.Propiedads.Where(p => p.id == propiedadSeleccionado.id).First();
                    var fotito = conec.fotos.Where(p => p.idPropiedad == propiedadaborrar.id).ToList();
                    if (tieneReserva(propiedadaborrar.id))
                    {
                        if (tieneSubasta(propiedadaborrar.id))
                        {
                            conec.fotos.RemoveRange(fotito);
                            conec.Propiedads.Remove(propiedadaborrar);
                            conec.SaveChanges();
                            bindingSource1.DataSource = llenarTablaConPropiedades();
                            gridControl1.Update();
                            inicializar();
                        }
                    }
                }
            }
        }

        private bool tieneSubasta(int idenPropiedad)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var subi = conec.subastas.Where(p => p.id_propiedad_subastada == idenPropiedad).ToList();
                if (subi.Count > 0)
                {

                    DialogResult result = MessageBox.Show("Tiene subastas activas, desea darla de baja de todas formas?", "Borrar", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        conec.subastas.RemoveRange(subi);
                        conec.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            return true;
        }

        private bool tieneReserva(int idenPropiedad)
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                var subi = conec.ReservaDirectas.Where(p => p.idPropiedad == idenPropiedad).ToList();
                if (subi.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Tiene reservas pendientes, desea darla de baja de todas formas?", "Borrar", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        conec.ReservaDirectas.RemoveRange(subi);
                        conec.SaveChanges();
                        return true;
                    }
                    else return false;

                }
            }
            return true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
                Propiedad propiedadSeleccionada = (Propiedad)gridView1.GetFocusedRow();
                xfModificarPropiedad modificarPropiedad = new xfModificarPropiedad(propiedadSeleccionada.id);
                modificarPropiedad.Show(); 
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if ((Propiedad)gridView1.GetFocusedRow() != null) simpleButton1.Enabled = true;
            else simpleButton1.Enabled = false;
        }

        public void vuelveDeModificar()
        {
            gridControl1.Update();
            inicializar();
        }
    }
}
