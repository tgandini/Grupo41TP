using System;
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

namespace HSH_Desa_y_Test.xUC
{
    public partial class xfRegistrarceForm : DevExpress.XtraEditors.XtraForm
    {
        public xfRegistrarceForm(string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
        }

        private void Crear_Cuenta_Click(object sender, EventArgs e)
        {
            if (usuario.validarMail(textMail.Text)){
                if (!usuario.existeMailEnBaseDeDatos(textMail.Text))
                {
                    if (textNombre.Text != "" && textApellido.Text != "" && textContrasena.Text != "" && textMail.Text != "" && textFechaNacimiento.Text != "" && (textNroTarjeta.Text.Length == 16) && (textFechaVencimiento.Text != "") && textCodSeguridad.Text.Length == 3)
                    {
                        if (textContrasena.Text.Length < 6)
                        {
                            if (DateTime.Parse(textFechaVencimiento.Text).Year <= (DateTime.Today.Year - 18))
                            {
                                var user = new usuario(textNombre.Text, textApellido.Text, textContrasena.Text, textMail.Text, textFechaNacimiento.Text);
                                var tarjeta = new tarjeta(textNroTarjeta.Text, DateTime.Parse(textFechaVencimiento.Text), textCodSeguridad.Text);
                                user.tarjetas.Add(tarjeta);
                                using (ContextoEntity conec = new ContextoEntity())
                                {
                                    conec.usuarios.Add(user);
                                    conec.SaveChanges();
                                }
                            }
                            else MessageBox.Show("Tiene que ser mayor de edad");
                        }
                        else MessageBox.Show("La contraseña es demasiado corta");
                    }
                    else MessageBox.Show("Faltan completar campos");
            }
                else MessageBox.Show("El email ya esta en uso");
            }
            else MessageBox.Show("El formato del email es erróneo");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cancelar?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
            }
        }

        private void textContrasena_EditValueChanged(object sender, EventArgs e)
        {
            textContrasena.Text = "";
            textContrasena.Properties.UseSystemPasswordChar = true;
        }
    }
}
