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
    public partial class xfAltaSubasta : DevExpress.XtraEditors.XtraForm
    {
        public xfAltaSubasta()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subasta nuevaSubasta = new subasta(comboBox1.AccessibilityObject.Value, numericUpDown1.Value, maskedTextBox1.V, maskedTextBox2.AccessibilityObject.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
