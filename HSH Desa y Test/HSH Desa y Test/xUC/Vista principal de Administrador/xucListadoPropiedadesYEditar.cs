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
using DevExpress.XtraGrid.Views.Grid;

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
            bindingPropiedad.DataSource = traerPropiedadesDeDb();            
            gridView1.SelectRow(3);
        }

        private object traerPropiedadesDeDb()
        {
            using (ContextoEntity contexto = new ContextoEntity())
            {
                return contexto.Propiedads.OrderBy(p => p.id).ToList();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int idProp = ((Propiedad)gridView1.GetFocusedRow()).id;
            xUCDetallePropiedad1.inicializar(idProp);
        }
    }
}
