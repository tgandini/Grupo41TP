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
        private List<byte[]> fotito=null;
        private Propiedad casa;
        public xfDarDeAltaPropiedad()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            casa = null;
            agregarFotosButton.Enabled = false;
        }

        private void crearButton2_Click(object sender, EventArgs e)
        {
            if((textHabitaciones.Text.Length > 0) && (textTipo.Text.Length >0) && (textUbicacion.Text.Length > 0))
            {
                if (int.Parse(textHabitaciones.Text) >= 0)
                {
                    casa = new Propiedad(textTipo.Text, textUbicacion.Text, int.Parse(textHabitaciones.Text), Sesion.admin.token, DateTime.Today);
                    if (fotito != null)
                    {
                        foreach (byte[] b in fotito)
                        {
                            foto ima = new foto(casa.id, b);
                            casa.fotos.Add(ima);
                        }
                    }
                    else casa.fotos = null;
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        if(casa.fotos!=null) conec.fotos.AddRange(casa.fotos);
                        conec.Propiedads.Add(casa);
                        conec.SaveChanges();
                    }
                    string pt = string.Concat("Se creo la propiedad con ubicacion: ", textUbicacion.Text);
                    MessageBox.Show(pt);
                    Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();

                    this.limpiarCampos();

                }
                else MessageBox.Show("La cantidad de habitaciones no es valida");
            }
            else MessageBox.Show("Faltan completar campos");
        }

        private void limpiarCampos()
        {
            this.textHabitaciones.Text = "";
            this.textTipo.Text = "";
            this.textUbicacion.Text = "";
        }

        private void cancelarButton1_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
            this.limpiarCampos();
        }

        private void agregarFotosButton_Click(object sender, EventArgs e)
        {
            using (xfAgregarImagenes agreg = new xfAgregarImagenes())
                {
                    agreg.ShowDialog();
                    fotito.AddRange(agreg.GetMyResult());
                }
            if (fotito != null) label5.Text = string.Concat("Se eligieron ",fotito.Count," fotos");
        }
    }
}