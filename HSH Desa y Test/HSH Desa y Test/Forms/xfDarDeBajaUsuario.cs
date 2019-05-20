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
using System.Data.Entity;
using HSH_Desa_y_Test.ContextoDB;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaUsuario : DevExpress.XtraEditors.XtraForm
    {
       
        public xfDarDeBajaUsuario()
            
        {
            InitializeComponent();
            /*usuarioBindingSource.DataSource = llenarTablaConUsuarios();
            if (usuarioBindingSource.Count < 1) simpleButton1.Enabled = false;
            gridControl1.DataSource = usuarioBindingSource;
            gridControl1.Update();*/
            simpleButton2.Enabled = false;
            this.CenterToScreen();

        }

    private List<usuario> llenarTablaConUsuarios()
    {
            using(ContextoEntity conec = new ContextoEntity()) { 
                return conec.usuarios.ToList();
            }
        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            usuario usuarioSeleccionado = (usuario) gridView1.GetFocusedRow();
            string st = string.Concat("Seguro que desea Borrar al usuario ", usuarioSeleccionado.mail, "?");
            DialogResult result = MessageBox.Show(st, "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (ContextoEntity conec = new ContextoEntity())
                {
                    var usuarioaborrar = conec.usuarios.Where(p => p.mail == usuarioSeleccionado.mail).First();
                    conec.usuarioParticipaEnSubastas.RemoveRange(usuarioaborrar.usuarioParticipaEnSubastas);
                    conec.tarjetas.RemoveRange(usuarioaborrar.tarjetas);
                    conec.usuarios.Remove(usuarioaborrar);
                    conec.SaveChanges();
                }
                /*usuarioBindingSource.DataSource = llenarTablaConUsuarios();
                if (usuarioBindingSource.Count < 1) simpleButton1.Enabled = false;
                gridControl1.DataSource = usuarioBindingSource;*/
                gridControl1.Update();

            }
            else if (result == DialogResult.No)
            {
            }
           

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEdit1.Checked)
            {
                gridView1.OptionsBehavior.Editable = true;
                gridView1.Columns.ColumnByFieldName("mail").OptionsColumn.AllowEdit = false;
                simpleButton2.Enabled = true;
            }
            else
            {
                gridView1.OptionsBehavior.Editable = false;
                simpleButton2.Enabled = false;
            }
        }

    /*    private void xfDarDeBajaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hSH_DesaYTestDataSet.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.hSH_DesaYTestDataSet.usuario);

        }*/

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Desea crear la subasta?", "Crear Subasta", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                gridView1.PostEditor();
                gridView1.UpdateCurrentRow();
                gridControl1.FocusedView.PostEditor();
                gridControl1.FocusedView.UpdateCurrentRow();
                usuarioTableAdapter.Update(gridView1.GetFocusedDataRow());
           }
        }
    }
}