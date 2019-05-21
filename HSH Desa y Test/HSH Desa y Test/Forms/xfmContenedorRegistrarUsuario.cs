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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfmContenedorRegistrarUsuario : DevExpress.XtraEditors.XtraForm
    {
        
        public xfmContenedorRegistrarUsuario()
        {
            InitializeComponent();
            Sesion.contenedorRegistrarUsuario = this;
        }
        public xfmContenedorRegistrarUsuario(string tituloYCambioBotonParam)
        {
            InitializeComponent();
            Sesion.contenedorRegistrarUsuario = this;
            this.xfRegistrarceForm1.SetearTexto("Registrarse");
            this.Text = "Registrarse";
            this.CenterToScreen();
        }
    }
}