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
    public partial class xfCambiarMontoSuscripcion : DevExpress.XtraEditors.XtraForm
    {
        private montosSubscripcion monto;
        public xfCambiarMontoSuscripcion()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            using (ContextoEntity conexion = new ContextoEntity())
            {
               monto = conexion.montosSubscripcions.First();
            }
            estandarEdit.Text = monto.estandar.ToString();
            premiumEdit.Text = monto.premium.ToString();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Desea cancelar?", "Cambiar montos", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            if (monto.estandar.ToString() != estandarEdit.Text || monto.premium.ToString() != premiumEdit.Text)
            {
                DialogResult m = MessageBox.Show("Desea cambiar los valores?", "Cambiar montos", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    montosSubscripcion mo = new montosSubscripcion(decimal.Parse(estandarEdit.Text), decimal.Parse(premiumEdit.Text));
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        conec.Entry(mo).State = System.Data.Entity.EntityState.Modified;
                        conec.SaveChanges();
                        MessageBox.Show("Se cambiaron los montos");
                    }
                }
            }
            else MessageBox.Show("Debe cambiar los valores primero");
        }
    }
}