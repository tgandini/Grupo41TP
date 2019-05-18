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
    public partial class xfRegistrarceForm : DevExpress.XtraEditors.XtraForm
    {
        public xfRegistrarceForm(string titulo)
        {
            InitializeComponent();
            label1.Text = titulo;
        }

        private void Crear_Cuenta_Click(object sender, EventArgs e)
        {
            usuario user = new usuario();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
