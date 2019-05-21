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
using System.Data.Entity.Infrastructure;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCCerrarSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        private List<subasta> subi;
        private subasta s;
        List<int> iden;
        public xUCCerrarSubasta()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            subi = llenarConSubasta();
            iden = new List<int>();
            foreach (subasta s in subi)
            {
                if (s.fecha_fin.Day + 3 < DateTime.Today.Day)
                {
                   
                    iden.Add(s.id);
                }
                else
                {
                    subasta su = s;
                    using (ContextoEntity conec = new ContextoEntity())
                    {
                        su.fecha_fin = DateTime.Today;
                        DbEntityEntry<subasta> ee = conec.Entry(s);
                        ee.CurrentValues.SetValues(su);
                        conec.SaveChanges();
                    }
                }
            }
            subastaBox.DataSource = iden;
        }

        private List<subasta> llenarConSubasta()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.subastas.ToList();
            }
        }

        private void subastaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Propiedad po;
            usuarioParticipaEnSubasta usp;
            s = encontrarCual(subastaBox.SelectedItem.ToString());
            using (ContextoEntity conec = new ContextoEntity())
            {
                po = conec.Propiedads.Where(p => p.id == s.id_propiedad_subastada).FirstOrDefault();
                usp = conec.usuarioParticipaEnSubastas.Last();
            }
            textBox1.Text = po.ubicaciòn;
            montoBox.Text = usp.monto.ToString();
        }

        private subasta encontrarCual(string st)
        {
            foreach (subasta casa in subi)
            {
                if (casa.id == int.Parse(st))
                    return casa;
            }
            return null;
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Desea cerrar la subasta?", "Cerrar Subasta", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                subasta su = s;
                using (ContextoEntity conec = new ContextoEntity())
                {
                    su.fecha_fin = DateTime.Today;
                    DbEntityEntry<subasta> ee = conec.Entry(s);
                    ee.CurrentValues.SetValues(su);
                    conec.SaveChanges();
                }
                iden.Remove(s.id);
                subastaBox.DataSource = iden;
                MessageBox.Show("Se cerro la subasta");
                this.limpiar();
            }
        }

        private void limpiar()
        {
            textBox1.Text = "";
            montoBox.Text = "";
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }
    }
}
