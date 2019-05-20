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
using System.Data.Entity;
using HSH_Desa_y_Test.ContextoDB;
using System.Data.Entity.Infrastructure;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeBajaUsuario : DevExpress.XtraEditors.XtraForm
    {
        ContextoEntity conec = new ContextoEntity();
        public xfDarDeBajaUsuario()
            
        {
            InitializeComponent();
            usuarioBindingSource.DataSource = llenarTablaConUsuarios();
            if (usuarioBindingSource.Count < 1) simpleButton1.Enabled = false;           
            gridControl1.Update();
            simpleButton2.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            this.CenterToScreen();

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
                /*usuarioBindingSource.DataSource = llenarTablaConUsuarios();
                if (usuarioBindingSource.Count < 1) simpleButton1.Enabled = false;
                gridControl1.DataSource = usuarioBindingSource;
                gridControl1.Update();*/

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
            DialogResult m = MessageBox.Show("Modificar al usuario?", "Modificar Usuario", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                usuario usuarioSeleccionado = (usuario)gridView1.GetFocusedRow();
                    var usuarioaborrar = conec.usuarios.Where(p => p.mail == usuarioSeleccionado.mail).First();
                    DbEntityEntry<usuario> ee = conec.Entry(usuarioaborrar);
                    ee.CurrentValues.SetValues(usuarioSeleccionado);
                    conec.SaveChanges();                
                /*usuarioBindingSource.DataSource = llenarTablaConUsuarios();
                if (usuarioBindingSource.Count < 1) simpleButton1.Enabled = false;
                gridControl1.DataSource = usuarioBindingSource;
                gridControl1.Update();*/
            }
        }
    }
}