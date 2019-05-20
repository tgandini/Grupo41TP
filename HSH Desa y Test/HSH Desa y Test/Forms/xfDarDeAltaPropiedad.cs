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
        public xfDarDeAltaPropiedad()
        {
            InitializeComponent();
        }

        private void crearButton2_Click(object sender, EventArgs e)
        {
            if((textHabitaciones.Text.Length > 0) && (textTipo.Text.Length >0) && (textUbicacion.Text.Length > 0))
            {
                if (int.Parse(textHabitaciones.Text) >= 0)
                {
                    var casa = new Propiedad(textTipo.Text, textUbicacion.Text, int.Parse(textHabitaciones.Text), Sesion.admin.token, DateTime.Today);
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        conec.Propiedads.Add(casa);
                        conec.SaveChanges();
                    }
                    string pt = string.Concat("Se creo la propiedad con ubicacion: ", textUbicacion.Text);
                    MessageBox.Show(pt);
                    Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
                }
                else MessageBox.Show("La cantidad de habitaciones no es valida");
            }
            else MessageBox.Show("Faltan completar campos");
        }

        private void cancelarButton1_Click(object sender, EventArgs e)
        {
            Sesion.vistaPrincipalDeAdmin.ocultarFormsderivados();
        }
    }
}