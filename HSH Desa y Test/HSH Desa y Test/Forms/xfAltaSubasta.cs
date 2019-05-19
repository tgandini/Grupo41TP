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
        private List<Propiedad> propie;        
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
            Propiedad st = encontrarCual(comboBox1.AccessibilityObject.Value);
            if (st != null)
            {
                DialogResult m = MessageBox.Show("Desea crear la subasta?","Crear Subasta", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    subasta nuevaSubasta = new subasta(st, (int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value));
                }       
            }
            else MessageBox.Show("La propiedad elegida es errónea");
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

        private Propiedad encontrarCual(string st)
        {
            foreach (Propiedad casa in propie)
            {
                if (casa.id == int.Parse(st))                
                    return casa;                
            }
            return null;
        }
    }
}
