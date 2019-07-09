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
using System.Data.Entity;
using HSH_Desa_y_Test.ContextoDB;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.xUC
{
    public partial class xucListadoSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        public xucListadoSubasta()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            gridControl1.DataSource = this.traerSubastasBD();
            if (gridView1.RowCount > 0) xUCDetalleSubasta1.Visible = true;
            else xUCDetalleSubasta1.Visible = false;
            /*gridView1.SelectRow(3);
            subasta sus = (subasta)gridView1.GetFocusedRow();
            this.xUCDetalleSubasta1.inicializar(sus.id);*/
        }

        public List<subasta> traerSubastasBD()
        {
            List<subasta> s;
            using (ContextoEntity conec = new ContextoEntity())
            {
                s = conec.subastas.ToList();
            }
            if (s != null)
            {
                List<subasta> aborar = new List<subasta>();
                foreach (subasta su in s)
                {
                    if (!su.estaActiva())
                    {
                        aborar.Add(su);
                    }
                }
                s = s.Except(aborar).ToList();
            }
            return s;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRow() != null && Sesion.user != null)
            {
                int idProp = ((subasta)gridView1.GetFocusedRow()).id;
                xUCDetalleSubasta1.inicializar(idProp);
            }

        }
    }
}
