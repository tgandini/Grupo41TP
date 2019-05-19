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
using HSH_Desa_y_Test.xUC;
using HSH_Desa_y_Test.Modelo_Expandido;

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
            Sesion.guardarPantallaPrincipal(this);
        }

        public void instanciarConUsuario()
        {
            this.layoutControlItem1.Control = new xUCToolBarLogueado(false);
        }
        public void instanciarSinUsuarioLogueado()
        {
            this.layoutControlItem1.BeginInit();
            var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            this.layoutControlItem1.Control = new xUCtoolbardeslogueado();
            controlQueEstabaEnPanel.Parent = null;
            this.layoutControlItem1.EndInit();
        }

        internal void renderizarConUsuario()
        {
            this.layoutControlItem1.BeginInit();
            var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            this.layoutControlItem1.Control = new xUCToolBarLogueado(false);
            controlQueEstabaEnPanel.Parent = null;
            this.layoutControlItem1.EndInit();
            
        }

        internal void renderizarConAdmin()
        {
            this.layoutControlItem1.BeginInit();
            var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            this.layoutControlItem1.Control = new xUCToolBarLogueado(true);
            controlQueEstabaEnPanel.Parent = null;
            this.layoutControlItem1.EndInit();
        }
    }
    
}
