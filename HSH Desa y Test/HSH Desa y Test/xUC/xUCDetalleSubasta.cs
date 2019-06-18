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
        private usuarioParticipaEnSubasta usuar;
        private subasta muestra;
        public xUCDetalleSubasta()
        {
            InitializeComponent();

        }
        public void inicializar(int? idsubasta)
        {
            Random random = new Random();
            pujarButton.Enabled = false;

            using (ContextoEntity conexion = new ContextoEntity())
            {

                if (idsubasta == null || idsubasta < 0) //Se usa para traer una subasta random
                {
                    muestra = conexion.subastas.Where(p => p.id == random.Next(0, conexion.subastas.Count() - 1)).First();
                }
                else //Tenemos ID de subasta, vamos a buscar los datos de esa subasta
                {
                    muestra = conexion.subastas.Where(p => p.id == idsubasta).First();
                }

                //Busca los datos del q va ganando en la subasta para mostrar en los label

                var casa = conexion.Propiedads.Where(p => p.id == muestra.id_propiedad_subastada).FirstOrDefault();
                usuar = conexion.usuarioParticipaEnSubastas.Where(p => p.idSubasta == muestra.id).ToList().LastOrDefault();

                //Seteo los label a cada cosa
                nombreLabel.Text = casa.nombre;
                ciudadLabel.Text = casa.ciudad;
                ubicacionPropiedad.Text = casa.ubicaciòn;
                if (usuar != null) ultimaPuja.Text = usuar.monto.ToString();
                else ultimaPuja.Text = muestra.monto_inicial.ToString();
                semanaSubastadaConAño.Text = string.Concat("Semana ", muestra.semana_de_subasta);
                label10.Text = muestra.añoReservado.ToString();
                label8.Text = muestra.fecha_fin.ToString();

            }
        }

        private void pujarButton_Click(object sender, EventArgs e)
        {
            if ((textNuevaPuja.Text.Length > 0) && (decimal.Parse(textNuevaPuja.Text) > decimal.Parse(ultimaPuja.Text)))
            {
                if (Sesion.user.token > 0)
                {
                    DialogResult result = MessageBox.Show("Confirma la puja?", "Puja", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        usuarioParticipaEnSubasta nuevapuja = new usuarioParticipaEnSubasta(decimal.Parse(textNuevaPuja.Text), Sesion.user.mail, muestra.id);
                        nuevapuja.crear();
                        ultimaPuja.Text = textNuevaPuja.Text;
                        textNuevaPuja.Text = "";
                        pujarButton.Enabled = false;
                    }
                }
                else MessageBox.Show("No tiene creditos suficientes");
            }
            else MessageBox.Show(string.Format("Debe ingresar un monto valido, debe superar {0}", ultimaPuja.Text));
        }

        private void textNuevaPuja_EditValueChanged(object sender, EventArgs e)
        {
            if ((textNuevaPuja.Text.Length > 0) && (decimal.Parse(textNuevaPuja.Text) > decimal.Parse(ultimaPuja.Text)))
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
