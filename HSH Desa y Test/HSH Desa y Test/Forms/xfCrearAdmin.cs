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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfCrearAdmin : DevExpress.XtraEditors.XtraForm
    {
        public xfCrearAdmin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (textEdit1.Text.Length != 10) MessageBox.Show("Tiene que tener 10 caracteres");
            else
            {
                DialogResult result = MessageBox.Show("Quiere crear el administrador?", "Crear Administrador", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    admin adm = new admin(textEdit1.Text);
                    using (ContextoEntity conexion = new ContextoEntity())
                    {
                        if (!conexion.admins.Any(p => p.token == adm.token))
                        {
                            conexion.admins.Add(adm);
                            conexion.SaveChanges();
                            MessageBox.Show(string.Format("Se creo el Administrador {0}", adm.token));
                            this.Close();
                        }
                        else MessageBox.Show("Ya esta en uso el token");
                    }
                }
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere cancelar?", "Crear Administrador", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }
    }
}