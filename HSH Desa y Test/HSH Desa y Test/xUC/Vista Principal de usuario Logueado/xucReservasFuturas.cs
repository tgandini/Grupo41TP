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
using HSH_Desa_y_Test.Modelo_Expandido;
using HSH_Desa_y_Test.ContextoDB;

namespace HSH_Desa_y_Test.xUC.Vista_Principal_de_usuario_Logueado
{
    public partial class xucReservasFuturas : DevExpress.XtraEditors.XtraUserControl
    {
        public xucReservasFuturas()
        {
            InitializeComponent();           
        }
        public void inicializar()
        {
            this.reservaFuturaBindingSource.DataSource = Sesion.user.ReservasFuturas;
            this.gridControl1.Refresh();
        }
        private void clickEnCelda(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Caption=="Cancelar Reserva")
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea cancelar la reserva seleccionada?", "Cancelar Reserva", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ReservaFutura tuplaElegida = gridView1.GetFocusedRow() as ReservaFutura;  
                    switch (tuplaElegida.tipoReserva)
                    {
                        //toDo: Ver lógica de cuando se puede eliminar y cuando no
                        case "Reserva Directa":
                            MessageBox.Show(string.Format("Eliminar Reserva directa con id:{0}", tuplaElegida.idReserva));
                            break;
                        case "Hot Sale":
                            HotSale.getOneById(tuplaElegida.idReserva).cancelarGanador(this);
                            break;
                        case "Subasta Ganada":
                            MessageBox.Show(string.Format("Eliminar Subasta con id:{0}", tuplaElegida.idReserva));
                            break;
                    }                 
                }
                
            }
        }
    }
}
