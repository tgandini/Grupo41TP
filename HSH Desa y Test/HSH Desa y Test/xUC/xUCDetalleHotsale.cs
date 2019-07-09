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
    public partial class xUCDetalleHotsale : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCDetalleHotsale()
        {
            InitializeComponent();
        }

        public void inicializar(HotSale hot, Propiedad prop)
        {
            nombreLabel.Text = prop.nombre;
            ciudadLabel.Text = prop.ciudad;
        }
    }
}
