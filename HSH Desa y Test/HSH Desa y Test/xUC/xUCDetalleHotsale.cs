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
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCDetalleHotsale : DevExpress.XtraEditors.XtraUserControl
    {
        private HotSale hot;
        public xUCDetalleHotsale()
        {
            InitializeComponent();
        }

        public void inicializar(HotSale hots, Propiedad prop)
        {
            if (Sesion.user != null) simpleButton1.Visible = true;
            else simpleButton1.Visible = false;
            hot = hots;
            nombreLabel.Text = prop.nombre;
            ciudadLabel.Text = prop.ciudad;
            ubicacionLabel.Text = prop.ubicaciòn;
            provinciaLabel.Text = prop.provincia;
            paisLabel.Text = prop.pais;
            fechaLabel.Text = Semanizador.LunesDeSemana(hot.añoReservado, hot.semanaReservada).Date.ToString();
            montoLabel.Text = hot.monto.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere realizar la comprar?", "Comprar HotSale", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (hot.idUsuario == null)
                {
                    using (ContextoEntity conexion = new ContextoEntity())
                    {
                        hot.idUsuario= Sesion.user.mail;
                        conexion.Entry(hot).State = System.Data.Entity.EntityState.Modified;
                        conexion.SaveChanges();
                    }
                    MessageBox.Show("Se Realizo la compra con exito");
                }
                else MessageBox.Show("Ya no se encuentra a la venta");
            }
        }
    }
}
