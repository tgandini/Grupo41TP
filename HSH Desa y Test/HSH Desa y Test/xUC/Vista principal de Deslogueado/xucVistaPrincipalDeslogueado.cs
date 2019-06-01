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

namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Deslogueado
{
    public partial class xucVistaPrincipalDeslogueado : DevExpress.XtraEditors.XtraUserControl
    {
        public xucVistaPrincipalDeslogueado()
        {
            InitializeComponent();
        }
        public void inicializar()
        {
            this.xucProp1.inicializar(-1);
            this.xucProp2.inicializar(-1);
        }
    }
}
