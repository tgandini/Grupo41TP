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
    public partial class xucAltaUsuario : DevExpress.XtraEditors.XtraUserControl
    {
        public xucAltaUsuario()
        {
            InitializeComponent();
        }

        private void ClickBoton(object sender, EventArgs e)
        {
            var user = new usuario(textEdit1.Text, textEdit2.Text, textEdit4.Text, textEdit5.Text, textEdit3.Text);
            var tarjeta = new tarjeta(textEdit6.Text, DateTime.Parse(textEdit7.Text), textEdit8.Text);
            user.tarjetas.Add(tarjeta);
            using (ContextoEntity conec = new ContextoEntity())
            {
                conec.usuarios.Add(user);
                conec.SaveChanges();
            }
                
            
        }
    }
}
