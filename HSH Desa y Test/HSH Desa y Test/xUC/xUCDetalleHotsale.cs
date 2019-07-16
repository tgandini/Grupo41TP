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
            fechaLabel.Text = Semanizador.LunesDeSemana(hot.añoReservado, hot.semanaReservada).Date.ToShortDateString();
            montoLabel.Text = hot.monto.ToString();
        }

        public void inicializar(HotSale hots)
        {
            if (Sesion.user != null) simpleButton1.Visible = true;
            else simpleButton1.Visible = false;
            hot = hots;
            Propiedad prop;
            using (ContextoEntity conexion = new ContextoEntity())
            {
                prop = conexion.Propiedads.Where(p=> p.id == hot.idPropiedad).First();
            }
            nombreLabel.Text = prop.nombre;
            ciudadLabel.Text = prop.ciudad;
            ubicacionLabel.Text = prop.ubicaciòn;
            provinciaLabel.Text = prop.provincia;
            paisLabel.Text = prop.pais;
            fechaLabel.Text = Semanizador.LunesDeSemana(hot.añoReservado, hot.semanaReservada).Date.ToString();
            montoLabel.Text = hot.monto.ToString();
        }

        public void inicializar()
        {
            HotSale h;
            Random random = new Random();
            HotSale[] aux;
            List<HotSale> aux2=new List<HotSale>();
            Propiedad p;
            using (ContextoEntity conexion = new ContextoEntity())
            {
                aux = conexion.HotSales.ToArray();
            }
            foreach(HotSale r in aux)
            {
                if (r.fechaInicio <= DateTime.Now && r.fechaFin >= DateTime.Now && r.idUsuario == null) aux2.Add(r);
            }
            if (aux2.Count() > 0)
            {
                aux = aux2.ToArray();
                h = aux[random.Next(0, aux.Length - 1)];
                using (ContextoEntity conexion = new ContextoEntity())
                {
                    p = conexion.Propiedads.Where(t => t.id == h.idPropiedad).First();
                }
                Sesion.vistaPrincipal.renderizarHot();
                this.inicializar(h, p);
            }
            else Sesion.vistaPrincipal.renderizarProp();
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
                    Sesion.vistaPrincipalUserLogueado.inicializarHotSale();
                }
                else MessageBox.Show("Ya no se encuentra a la venta");
            }
        }
    }
}
