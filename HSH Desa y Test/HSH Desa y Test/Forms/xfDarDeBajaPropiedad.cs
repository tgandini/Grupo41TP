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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaPropiedad : DevExpress.XtraEditors.XtraUserControl
    {

        ContextoEntity conec = new ContextoEntity();
        private List<byte[]> fotito=null;
        public xfDarDeBajaPropiedad()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            bindingSource1.DataSource = llenarTablaConPropiedades();
            if (bindingSource1.Count < 1)
            {
                simpleButton1.Enabled = false;
                checkEdit1.Enabled = false;
                noHayPropiedades.Visible = true;
            }
            else noHayPropiedades.Visible = false;
            gridControl1.Update();
            simpleButton2.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            label2.Visible = false;
            label3.Visible = false;
            agregarFotoButton.Enabled = false;
            eliminarFotoButton.Enabled = false;
            fotito = null;
        }

        private List<Propiedad> llenarTablaConPropiedades()
        {
           
                return conec.Propiedads.ToList();

        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            Propiedad propiedadSeleccionado = (Propiedad)gridView1.GetFocusedRow();
            string st = string.Concat("Seguro que desea Borrar la propiedad ", propiedadSeleccionado.id, "?");
            DialogResult result = MessageBox.Show(st, "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var propiedadaborrar = conec.Propiedads.Where(p => p.id == propiedadSeleccionado.id).First();
                conec.Propiedads.Remove(propiedadaborrar);
                conec.SaveChanges();
                bindingSource1.DataSource = llenarTablaConPropiedades();
                gridControl1.Update();
                inicializar();
            }
        }
        //Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkEdit1.Checked) && (bindingSource1.Count >= 1))
            {
                gridView1.OptionsBehavior.Editable = true;
                gridView1.Columns.ColumnByFieldName("id").OptionsColumn.AllowEdit = false;
                simpleButton2.Enabled = true;
                label2.Visible = true;
                agregarFotoButton.Enabled = true;
                eliminarFotoButton.Enabled = true;
            }
            else
            {
                gridView1.OptionsBehavior.Editable = false;
                simpleButton2.Enabled = false;
                label2.Visible = false;
                agregarFotoButton.Enabled = false;
                eliminarFotoButton.Enabled = false;
                label3.Visible = false;
                fotito = null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Modificar la propiedad?", "Modificar Propiedad", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                Propiedad propiedadSeleccionado = (Propiedad)gridView1.GetFocusedRow();
                var propiedadaborrar = conec.Propiedads.Where(p => p.id == propiedadSeleccionado.id).First();
                if (fotito != null)
                {
                    foreach (byte[] b in fotito)
                    {
                        foto ima = new foto(propiedadaborrar.id, b);
                        conec.fotos.Add(ima);
                    }
                }
                fotito = null;
                label3.Visible = false;
                DbEntityEntry<Propiedad> ee = conec.Entry(propiedadaborrar);
                ee.CurrentValues.SetValues(propiedadSeleccionado);
                conec.SaveChanges();
            }
            //Modelo_Expandido.Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
        }

        private void agregarFotoButton_Click(object sender, EventArgs e)
        {
            using (xfAgregarImagenes agreg = new xfAgregarImagenes())
            {
                agreg.ShowDialog();
                fotito=agreg.GetMyResult();
            }
            if (fotito != null) label3.Visible = true;
        }

        private void eliminarFotoButton_Click(object sender, EventArgs e)
        {
            Propiedad propiedadSeleccionado = (Propiedad)gridView1.GetFocusedRow();
            xfEliminarFoto el = new xfEliminarFoto(propiedadSeleccionado.id);
        }
    }
}
