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
using HSH_Desa_y_Test.Modelo_Expandido;
using System.Globalization;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xfRegistrarceForm : DevExpress.XtraEditors.XtraUserControl
    {
        
        public xfRegistrarceForm()
        {
            InitializeComponent();
        }

        private void Crear_Cuenta_Click(object sender, EventArgs e)
        {
            if (usuario.validarMail(textMail.Text))
            {
                if (!usuario.existeMailEnBaseDeDatos(textMail.Text))
                {
                    if ((textNombre.Text.Length > 0) && (textApellido.Text.Length > 0) && (textContrasena.Text.Length > 0) && (textMail.Text.Length > 0) && (textFechaNacimiento.Text.Length > 0))
                    {
                        if ((tarjeta.sacarGuiones(textNroTarjeta.Text).Length == 16) && (textFechaVencimiento.Text.Length > 0) && (textCodSeguridad.Text.Length == 3))
                        {
                            if (tarjeta.ValidarFechaVencimiento(textFechaVencimiento.Text))
                            {
                                if (textContrasena.Text.Length >= 6)
                                {
                                    var edad = DateTime.Today.Year - DateTime.Parse(textFechaNacimiento.Text).Year;
                                    if (DateTime.Parse(textFechaNacimiento.Text).Date > DateTime.Today.AddYears(-edad)) edad--;
                                    if (edad >= 18)
                                    {
                                        var user = new usuario(textNombre.Text, textApellido.Text, textContrasena.Text, textMail.Text, textFechaNacimiento.Text);
                                        var tarjeta = new tarjeta(textNroTarjeta.Text, DateTime.ParseExact(textFechaVencimiento.Text,"MM/yy", new CultureInfo("es-AR")), textCodSeguridad.Text);
                                        user.tarjetas.Add(tarjeta);
                                        using (ContextoEntity conec = new ContextoEntity())
                                        {
                                            conec.usuarios.Add(user);
                                            conec.SaveChanges();
                                        }
                                        string pt = string.Concat("Se creo la cuenta de usuario para: ", textMail.Text);
                                        MessageBox.Show(pt);
                                        Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
                                        if (Sesion.contenedorRegistrarUsuario != null) Sesion.contenedorRegistrarUsuario.Close();
                                    }
                                    else MessageBox.Show("Tiene que ser mayor de edad");
                                }
                                else MessageBox.Show("La contraseña es demasiado corta");
                            }
                            else MessageBox.Show("La tarjeta ya venció");
                        }
                        else MessageBox.Show("Faltan completar campos tarjeta");
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
                Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
                if (Sesion.contenedorRegistrarUsuario != null) Sesion.contenedorRegistrarUsuario.Close();
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
        public void SetearTexto(string textoParam)
        {
            this.label1.Text = textoParam;
            this.Crear_Cuenta.Text = textoParam;
        }
    }
}
