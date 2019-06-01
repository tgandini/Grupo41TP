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

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfModificarPropiedad : DevExpress.XtraEditors.XtraForm
    {
        Propiedad propiedadAModificar = null;

        public xfModificarPropiedad()
        {
            InitializeComponent();
        }

        public xfModificarPropiedad(int idPropiedad)
        {
            InitializeComponent();
            cargarPropiedadAModificar(idPropiedad);
        }

        public void cargarPropiedadAModificar(int idPropiedad)
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
                propiedadAModificar = conexion.Propiedads.Where(p => p.id == idPropiedad).First();
                nombre.Text = propiedadAModificar.nombre;
                ciudad.Text = propiedadAModificar.ciudad;
                prov.Text = propiedadAModificar.provincia;
                pais.Text =  propiedadAModificar.pais;
                tipo.Text = propiedadAModificar.tipo;
                cantHabitaciones.Value = propiedadAModificar.habitaciones;
            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea modificar los datos de la propiedad?", "Cambio de Datos de Propiedad", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.No)
            {
                this.Close();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}