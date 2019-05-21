using System;
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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaPropiedad : DevExpress.XtraEditors.XtraUserControl
    {
        
        public xfDarDeBajaPropiedad()
        {
            InitializeComponent();
        }

        private void inicializar()
        {
            bindingSource1.DataSource = llenarTablaConPropiedades();
            if (bindingSource1.Count < 1)
            {
                simpleButton1.Enabled = false;
                checkEdit1.Enabled = false;
            }
            gridControl1.Update();
            simpleButton2.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            label2.Visible = false;
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
            DialogResult result = MessageBox.Show(st, "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //using (ContextoEntity conec = new ContextoEntity())
                //{
                //    var propiedadaborrar = conec.Propiedads.Where(p => p.id == propiedadSeleccionado.id).First();
                //    conec.Propiedads.Remove(propiedadaborrar);
                //    conec.SaveChanges();
                //    bindingSource1.DataSource = llenarTablaConPropiedades();
                //    gridControl1.Update();
                //    if (bindingSource1.Count < 1)
                //    {
                //        gridView1.OptionsBehavior.Editable = false;
                //        simpleButton2.Enabled = false;
                //        label2.Visible = false;
                //        checkEdit1.Enabled = false;
                //    }
                //}

            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkEdit1.Checked) && (bindingSource1.Count >= 1))
            {
                gridView1.OptionsBehavior.Editable = true;
                gridView1.Columns.ColumnByFieldName("id").OptionsColumn.AllowEdit = false;
                simpleButton2.Enabled = true;
                label2.Visible = true;
            }
            else
            {
                gridView1.OptionsBehavior.Editable = false;
                simpleButton2.Enabled = false;
                label2.Visible = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Modificar al propiedad?", "Modificar Propiedad", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                //using (ContextoEntity conec = new ContextoEntity())
                //{
                //    Propiedad propiedadSeleccionado = (Propiedad)gridView1.GetFocusedRow();
                //    var propiedadaborrar = conec.Propiedads.Where(p => p.id == propiedadSeleccionado.id).First();
                //    DbEntityEntry<Propiedad> ee = conec.Entry(propiedadaborrar);
                //    ee.CurrentValues.SetValues(propiedadSeleccionado);
                //    conec.SaveChanges();
                //}

            }
            Modelo_Expandido.Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
        }

        private void ucCargó(object sender, EventArgs e)
        {
            this.inicializar();
        }
    }
}