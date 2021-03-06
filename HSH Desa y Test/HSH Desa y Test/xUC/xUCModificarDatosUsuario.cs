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
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;
using System.Data.Entity.Infrastructure;
using HSH_Desa_y_Test.Forms;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCModificarDatosUsuario : DevExpress.XtraEditors.XtraForm
    {
        usuario usuarioAModificar = null;
        public delegate void modificarUsuarioEventHandler();
        public event modificarUsuarioEventHandler seModificoUsuario;

        public xUCModificarDatosUsuario(string mailUsuario)
        {
            InitializeComponent();
            cargarUsuarioAModificar(mailUsuario);
        }

        public void cargarUsuarioAModificar(string mailUsuario)
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                usuarioAModificar = conexion.usuarios.Where(p => p.mail == mailUsuario).First();
                nombre.Text = usuarioAModificar.nombre;
                ape.Text = usuarioAModificar.apellido;
                mail.Text = usuarioAModificar.mail;
                nac.Text = usuarioAModificar.fecha_nacimiento.ToString("dd/MM/yyyy");
                reg.Text = usuarioAModificar.fecha_registro.ToString("dd/MM/yyyy");
                premium.Checked = usuarioAModificar.premium;
                if (Sesion.hayUserLogueado() == true) premium.Enabled = false;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar los datos del usuario?", "Cambio de Datos de Usuario", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                usuarioAModificar.nombre = nombre.Text;
                usuarioAModificar.apellido = ape.Text;
                usuarioAModificar.fecha_nacimiento = DateTime.Parse(nac.Text);
                usuarioAModificar.premium = premium.Checked;

                using (ContextoEntity conexion = new ContextoEntity())
                {
                    if (DateTime.Compare(usuarioAModificar.fecha_nacimiento.AddYears(18), DateTime.Today) > 0)
                    {
                        MessageBox.Show("El usuario no puede ser menor de edad.", "Error en Fecha Nacimiento");
                        return;
                    }
                    if (usuarioAModificar.nombre == "" || usuarioAModificar.apellido == "" || usuarioAModificar.mail == "" || usuarioAModificar.fecha_nacimiento.ToString() == "")
                    {
                        MessageBox.Show("Ningun campo puede estar vacio.", "Campo vacio");
                        return;
                    }
                    conexion.Entry(usuarioAModificar).State = System.Data.Entity.EntityState.Modified;
                    conexion.SaveChanges();
                }
                Sesion.user = this.usuarioAModificar;
                //Sesion.vistaPrincipalDeAdmin.vuelveDeModificarUsuario();
                if (seModificoUsuario != null) seModificoUsuario();
                this.Close();

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea cancelar la modificacion de datos del usuario?", "Cambio de Datos de Usuario", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
            else return;
        }
    }
}
