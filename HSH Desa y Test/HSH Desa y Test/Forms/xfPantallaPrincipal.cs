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
using DevExpress.XtraLayout;

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

            this.instanciarSinUsuarioLogueado();
        }

        //public void instanciarConUsuario()
        //{
        //    this.layoutControlItem1.Control = new xUCToolBarLogueado(false);
        //}
        public void instanciarSinUsuarioLogueado()
        {
            //    this.layoutControlItem1.BeginInit();
            //    var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            //    this.layoutControlItem1.Control = new xUCtoolbardeslogueado();
            //    controlQueEstabaEnPanel.Parent = null;
            //    this.layoutControlItem1.EndInit();


        }

        internal void renderizarConUsuario()
        {
            //this.layoutControlItem1.BeginInit();
            //var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            //this.layoutControlItem1.Control = new xUCToolBarLogueado(false);
            //controlQueEstabaEnPanel.Parent = null;
            //this.layoutControlItem1.EndInit();
            //(LayoutControlItem )layoutControl1.Controls
            //LayoutControlItem asd = (LayoutControlItem)layoutControl1.Items.FindByName("Barra Toolbar");
            //asd.Control = new xUCToolBarLogueado();
        }

        internal void renderizarConAdmin()
        {
            //    this.layoutControlItem1.BeginInit();
            //    var controlQueEstabaEnPanel = this.layoutControlItem1.Control;
            //    this.layoutControlItem1.Control = new xUCToolBarLogueado(true);
            //    controlQueEstabaEnPanel.Parent = null;
            //    this.layoutControlItem1.EndInit();
            //layoutControl1.BeginInit();
            //LayoutControlItem asd = (LayoutControlItem)layoutControl1.Items.FindByName("Barra Toolbar");
            //asd.Control = new xUCToolBarLogueado(true);
            //layoutControl1.EndInit();
            //LayoutControlItem layoutSinLoguear = layoutControl1.Root.AddItem();
            //layoutSinLoguear.Name = "Barra Toolbarasd";
            //layoutSinLoguear.Control = new xUCToolBarLogueado(true);
  

        }
    }
    
}
