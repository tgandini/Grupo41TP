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
using System.Data.Entity.Infrastructure;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        private ContextoEntity conec = new ContextoEntity();
        public xfDarDeBajaUsuario()
            
        {
            InitializeComponent();
            

        }

        public void inicializar()
        {
            usuarioBindingSource.SuspendBinding();
            usuarioBindingSource.DataSource = llenarTablaConUsuarios();
            if (usuarioBindingSource.Count < 1)
            {
                simpleButton1.Enabled = false;
                checkEdit1.Enabled = false;
            }
            gridControl1.Update();
            simpleButton2.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            label2.Visible = false;
        }

        private List<usuario> llenarTablaConUsuarios()
          {

                return conec.usuarios.ToList();
           
            }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            usuario usuarioSeleccionado = (usuario) gridView1.GetFocusedRow();
            string st = string.Concat("Seguro que desea Borrar al usuario ", usuarioSeleccionado.mail, "?");
            DialogResult result = MessageBox.Show(st, "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
               
                    var usuarioaborrar = conec.usuarios.Where(p => p.mail == usuarioSeleccionado.mail).First();
                    conec.usuarioParticipaEnSubastas.RemoveRange(usuarioaborrar.usuarioParticipaEnSubastas);
                    conec.tarjetas.RemoveRange(usuarioaborrar.tarjetas);
                    conec.usuarios.Remove(usuarioaborrar);
                    conec.SaveChanges();
                
                usuarioBindingSource.DataSource = llenarTablaConUsuarios();
                gridControl1.Update();
                if (usuarioBindingSource.Count < 1)
                {
                    gridView1.OptionsBehavior.Editable = false;
                    simpleButton2.Enabled = false;
                    label2.Visible = false;
                    checkEdit1.Enabled = false;
                }
            } 
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if((checkEdit1.Checked) && (usuarioBindingSource.Count >= 1))
                {
                gridView1.OptionsBehavior.Editable = true;
                gridView1.Columns.ColumnByFieldName("mail").OptionsColumn.AllowEdit = false;
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
            DialogResult m = MessageBox.Show("Modificar al usuario?", "Modificar Usuario", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                usuario usuarioSeleccionado = (usuario)gridView1.GetFocusedRow();
                
                    var usuarioaborrar = conec.usuarios.Where(p => p.mail == usuarioSeleccionado.mail).First();
                    DbEntityEntry<usuario> ee = conec.Entry(usuarioaborrar);
                    ee.CurrentValues.SetValues(usuarioSeleccionado);
                    conec.SaveChanges();
                
            }
        }
    }
}