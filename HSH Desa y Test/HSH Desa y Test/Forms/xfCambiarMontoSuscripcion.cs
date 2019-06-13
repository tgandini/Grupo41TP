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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfCambiarMontoSuscripcion : DevExpress.XtraEditors.XtraForm
    {
        public xfCambiarMontoSuscripcion()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
            }
        }
    }
}