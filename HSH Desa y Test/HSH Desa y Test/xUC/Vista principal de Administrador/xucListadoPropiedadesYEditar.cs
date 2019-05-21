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
using DevExpress.XtraGrid;

namespace HSH_Desa_y_Test.xUC.Vista_principal_de_Administrador
{
    public partial class xucListadoPropiedadesYEditar : DevExpress.XtraEditors.XtraUserControl
    {
        public xucListadoPropiedadesYEditar()
        {
            InitializeComponent();
        }
        public void CargarDatos()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                bindingPropiedad.DataSource = conec.Propiedads.OrderBy(p => p.id);

            }
            gridView1.SelectRow(0);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            xUCDetallePropiedad1.inicializar(e.FocusedRowHandle);
        }
    }
}
