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

namespace HSH_Desa_y_Test.Forms
{
    public static List<Propiedad> propie = new List<Propiedad>();
    public partial class xfAltaSubasta : DevExpress.XtraEditors.XtraForm
    {
        public xfAltaSubasta()
        {
            InitializeComponent();
            propie = llenarConPropiedades();
            List<int> iden = new List<int>();
            foreach (Propiedad casa in propie)
            {
                iden.Add(casa.id);
            }
            comboBox1.DataSource = iden;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           subasta nuevaSubasta = new subasta(comboBox1.AccessibilityObject.Value, (int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private List<Propiedad> llenarConPropiedades()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.Propiedads.ToList();
            }
        }

        private Propiedad encontrarCual
    }
}
