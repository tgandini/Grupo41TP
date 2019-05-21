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

namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCCerrarSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        private List<subasta> subi;
        public xUCCerrarSubasta()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            subi = llenarConSubasta();
            List<int> iden = new List<int>();
            foreach (subasta s in subi)
            {
                if(s.fecha_fin.Day+3 <DateTime.Today.Day)
                    iden.Add(s.id);
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
    }
}
