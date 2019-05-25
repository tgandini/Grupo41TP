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
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfFormLogin : DevExpress.XtraEditors.XtraForm
    {

        //Constructor Base
        public xfFormLogin()
        {
            InitializeComponent();
            this.setearPorDefecto();
        }

        //Constructor con parámetro del form principal
    

        private void setearPorDefecto()
        {
            this.CenterToScreen();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }
        //Click para loguear como usuario
        private void usuarioClick(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            layoutControlItem4.Text = "Contraseña:";
            layoutControlItem3.ContentVisible = true;
            
        }

        //Click para loguear como Admin
             private void adminClick(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = true;
            layoutControlItem4.Text = "Token de admin:";
            layoutControlItem3.ContentVisible = false;
           
        }

        private void okClickeado(object sender, EventArgs e)
        {

            //Quiere iniciar como usuario
            if (radioButton1.Checked)
            {
                Sesion.user = usuario.traerDeDb(textEdit1.Text, textEdit2.Text);
                if (Sesion.user != null)
                {
                    Sesion.admin = null;
                    Sesion.getVistaPrincipal().renderizarConUsuario();
                    this.Close();
                }
                else//
                {
                   
                }
                
            }
            else //Quiere iniciar como admin
            {
                Sesion.admin = admin.traerDeDb(textEdit2.Text);
                if (Sesion.admin != null)
                {
                    Sesion.user = null;
                    Sesion.getVistaPrincipal().renderizarConAdmin();
                    this.Close();
                }
            }

            
        }
        
        private void cancelarClickeado(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}