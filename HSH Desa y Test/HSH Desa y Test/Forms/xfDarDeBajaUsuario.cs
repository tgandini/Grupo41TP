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
using HSH_Desa_y_Test.Modelo_Expandido;

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
                simpleButton2.Enabled = false;
            }
            gridControl1.Update();
            simpleButton2.Enabled = true;
            gridView1.OptionsBehavior.Editable = false;
        }


        private List<usuario> llenarTablaConUsuarios()
          {
            using (ContextoEntity nuevaConec = new ContextoEntity())
            {
                return nuevaConec.usuarios.ToList();
            }

        }

        private void DarDeBaja_Click(object sender, EventArgs e)
        {
            usuario usuarioSeleccionado = (usuario) gridView1.GetFocusedRow();
            string st = string.Concat("Seguro que desea Borrar al usuario ", usuarioSeleccionado.mail, "?");
            DialogResult result = MessageBox.Show(st, "Salir",MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
               
                    var usuarioaborrar = conec.usuarios.Where(p => p.mail == usuarioSeleccionado.mail).First();
                    //conec.usuarioParticipaEnSubastas.RemoveRange(usuarioaborrar.usuarioParticipaEnSubastas);
                    conec.tarjetas.RemoveRange(usuarioaborrar.tarjetas);
                    conec.usuarios.Remove(usuarioaborrar);
                    conec.SaveChanges();
                
                usuarioBindingSource.DataSource = llenarTablaConUsuarios();
                gridControl1.Update();
                if (usuarioBindingSource.Count < 1)
                {
                    gridView1.OptionsBehavior.Editable = false;
                    simpleButton1.Enabled = false;
                    simpleButton2.Enabled = false;
                }
            } 
        }

        public void vuelveDeModificar()
        {
            this.inicializar();
            if (usuarioBindingSource.Count < 1)
            {
                gridView1.OptionsBehavior.Editable = false;
                simpleButton1.Enabled = false;
                simpleButton2.Enabled = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            usuario usuarioAModificar = (usuario)gridView1.GetFocusedRow();
            xUC.xUCModificarDatosUsuario modificarUsuario = new xUC.xUCModificarDatosUsuario(usuarioAModificar.mail);
            modificarUsuario.Show();
        }
    }
}