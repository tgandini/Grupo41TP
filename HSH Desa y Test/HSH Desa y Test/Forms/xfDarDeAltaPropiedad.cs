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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfDarDeAltaPropiedad : DevExpress.XtraEditors.XtraUserControl
    {
        private List<byte[]> fotito;
        private Propiedad casa;
        public xfDarDeAltaPropiedad()
        {
            InitializeComponent();
            inicializar();
        }

        public void inicializar()
        {
            casa = null;
            label5.Visible = false;
        }

        private void crearButton2_Click(object sender, EventArgs e)
        {
            
            if((textHabitaciones.Text.Length > 0) && (textTipo.Text.Length >0) && (textUbicacion.Text.Length > 0)&& (boxNombre.Text.Length > 0)&& boxCiudad.Text.Length>0)
            {
                if (int.Parse(textHabitaciones.Text) >= 0)
                {
                    casa = new Propiedad(boxNombre.Text,boxCiudad.Text, textTipo.Text, textUbicacion.Text, int.Parse(textHabitaciones.Text), Sesion.admin.token, DateTime.Today);
                    if (fotito != null)
                    {
                        foreach (byte[] b in fotito)
                        {
                            foto ima = new foto(casa.id, b);
                            casa.fotos.Add(ima);
                        }
                    }
                    else casa.fotos = null;
                    if (casa.guardarAltaEnBD())
                    {
                        MessageBox.Show("Se dio de alta a la propiedad con éxito");
                        Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
                        this.limpiarCampos();
                    }                  


                }
                else MessageBox.Show("La cantidad de habitaciones no es valida");
            }
            else MessageBox.Show("Faltan completar campos");
        }

        private void limpiarCampos()
        {
            this.boxNombre.Text = "";
            this.boxCiudad.Text = "";
            this.textHabitaciones.Text = "";
            this.textTipo.Text = "";
            this.textUbicacion.Text = "";
            fotito = null;
            label5.Text = null;
        }

        private void cancelarButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar alta de propiedad", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
                this.limpiarCampos();
            }

        }

        private void agregarFotosButton_Click(object sender, EventArgs e)
        {
            using (xfAgregarImagenes agreg = new xfAgregarImagenes())
                {
                    agreg.ShowDialog();
                    fotito = agreg.Fot;
                }
            if (fotito != null)
            {
                label5.Text = string.Concat("Se eligieron ", fotito.Count, " fotos");
                label5.Visible = true;
            }
        }
    }
}