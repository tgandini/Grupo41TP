﻿using System;
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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCToolBarLogueado : DevExpress.XtraEditors.XtraUserControl
    {
        public xUCToolBarLogueado()
        {
            InitializeComponent();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cerrar Sesion?", "Salir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Sesion.user = null;
                //Hacer logica para volver a la pantalla inicio
            }
            else if (result == DialogResult.No)
            {
            }

        }
    }
}