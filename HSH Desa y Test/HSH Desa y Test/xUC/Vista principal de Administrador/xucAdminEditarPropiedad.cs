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

namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    public partial class xucAdminEditarPropiedad : DevExpress.XtraEditors.XtraUserControl
    {
        public xucAdminEditarPropiedad()
        {
            InitializeComponent();
            this.inicializar();

        }

        private void inicializar()
        {
            for (int i = 0; i < 20; i++)
            {
                comboBox1.Items.Add(i);
            }
        }
    }
}
