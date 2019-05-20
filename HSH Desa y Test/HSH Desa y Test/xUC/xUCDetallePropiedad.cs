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

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCDetallePropiedad : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCDetallePropiedad()
        {
            InitializeComponent();
            Random random = new Random();
            using (ContextoEntity conexion = new ContextoEntity())
            {
                Propiedad casa = conexion.Propiedads.ElementAtOrDefault(random.Next(0, conexion.Propiedads.Count() - 1));
                var stream = new MemoryStream(casa.fotos.ElementAtOrDefault(0).foto1);
                pictureBox1.Image = System.Drawing.Image.FromStream(stream);
                label4.Text = casa.tipo;
                label5.Text = casa.ubicaciòn;
                label6.Text = casa.habitaciones.ToString();
            }
        }
    }
}
