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
            this.CenterToScreen();
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
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        var montos = conec.montosSubscripcions.First();
                        montos.estandar = decimal.Parse(estandarEdit.Text);
                        montos.premium = decimal.Parse(premiumEdit.Text);
                        conec.Entry(montos).State = System.Data.Entity.EntityState.Modified;
                        conec.SaveChanges();
                        MessageBox.Show("Se cambiaron los montos");
                        this.Close();
                    }
                }
            }
            else MessageBox.Show("Debe cambiar los valores primero");
        }
    }
}