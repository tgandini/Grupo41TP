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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfPantallaPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public xfPantallaPrincipal()
        {
            InitializeComponent();
            this.inicializar();

        }

        private void inicializar()
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
