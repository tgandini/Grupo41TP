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
using System.IO;
using System.Data.Entity;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCDetalleSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        private decimal usuar;
        private subasta muestra;
        public xUCDetalleSubasta(int? idsubasta)
        {
            InitializeComponent();
            inicializar(idsubasta);
        }

        private void inicializar(int? idsubasta)
        {
            Random random = new Random();
            pujarButton.Enabled = false;

            using (ContextoEntity conexion = new ContextoEntity())
            {

                if (idsubasta == null || idsubasta < 0) //Se usa para traer las fotos de una subasta random
                {
                    muestra = conexion.subastas.Where(p => p.id == random.Next(0, conexion.subastas.Count() - 1)).First();
                }
                else //Tenemos ID de propiedad, vamos a buscar los datos de esa subasta
                {
                    muestra = conexion.subastas.Where(p => p.id == idsubasta & p.fecha_inicio < DateTime.Today).First();
                }
               
                //Busca los datos para mostrar en los label
                var casa = conexion.Propiedads.Where(p => p.id == muestra.id_propiedad_subastada).First().ubicaciòn;
                usuar = conexion.usuarioParticipaEnSubastas.Where(p => p.idSubasta == muestra.id).First().monto;

                //Seteo los label a cada cosa
                ubicacionPropiedad.Text = casa;
                ultimaPuja.Text = usuar.ToString();
                semanaSubastadaConAño.Text = string.Concat("Semana ", muestra.semana_de_subasta);
            }
        }

        private void pujarButton_Click(object sender, EventArgs e)
        {
            if ((textNuevaPuja.Text.Length > 0) && (decimal.Parse(textNuevaPuja.Text) > usuar))
            {
                DialogResult result = MessageBox.Show("Confirma la puja?", "Puja", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    usuarioParticipaEnSubasta nuevapuja = new usuarioParticipaEnSubasta(usuar, Sesion.user.mail, muestra.id);
                    nuevapuja.crear();
                    usuar = decimal.Parse(textNuevaPuja.Text);
                    ultimaPuja.Text = usuar.ToString();
                }
            }
            else MessageBox.Show("Debe ingresar un monto valido");
        }

        private void textNuevaPuja_EditValueChanged(object sender, EventArgs e)
        {
            if ((textNuevaPuja.Text.Length > 0) && (decimal.Parse(textNuevaPuja.Text) > usuar))
            {
                pujarButton.Enabled = true;
            }
            else
            {
                pujarButton.Enabled = false;
            }
        }
    }
}
