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
using HSH_Desa_y_Test.Forms;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCtoolbardeslogueado : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCtoolbardeslogueado()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            new xfFormLogin().ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formLogin = new xfmContenedorRegistrarUsuario("Registrarse");
            formLogin.Show();

        }

        private void clickEnAcerca(object sender, EventArgs e)
        {
            new xfPantallaContacto().ShowDialog();
        }
    }
}
