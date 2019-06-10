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
using System.Globalization;
using HSH_Desa_y_Test.Modelo_Expandido;

namespace HSH_Desa_y_Test.Forms
{
    public partial class xfAltaSubasta : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Propiedad> propie;        
        public xfAltaSubasta()
        {
            InitializeComponent();
           
        }

        public void inicializar()
        {
            
            propie = llenarConPropiedades();
            List<string> iden = new List<string>();
            iden.Clear();
            foreach (Propiedad casa in propie)
            {
                iden.Add(string.Format("{0}, ubicada en Ciudad: {1}, dirección:{2}", casa.nombre, casa.ciudad, casa.ubicaciòn));
            }
            comboBox1.DataSource = iden;


            //Checkeamos q no haya datos en el combobox de año
            if (comboBox2.Items.Count == 0)
            {
                for (int i = 0; i <= 2; i++)
                {
                    comboBox2.Items.Add(DateTime.Today.Year + i);
                }
                comboBox2.SelectedIndex = 0;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Propiedad st = encontrarCual(comboBox1.AccessibilityObject.Value);
            if (st != null)
            {
                DialogResult m = MessageBox.Show("Desea crear la subasta?","Crear Subasta", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    if (DateTime.Parse(maskedTextBox2.Text) >= (DateTime.Now))
                    {
                        DateTime fechaSemana = Semanizador.semanaSegunFechaInicio(DateTime.Now, int.Parse(numericUpDown1.Value.ToString()));                      
                        if (st.estaLibre(decimal.ToInt32(numericUpDown1.Value), fechaSemana.Year))
                        {
                            if (fechaSemana > DateTime.Parse(maskedTextBox2.Text).AddMonths(6))
                            {
                                subasta nuevaSubasta = new subasta((int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value));
                                nuevaSubasta.crear();
                                this.inicializar();
                            }
                            else MessageBox.Show("La semana elegida debe superar en 6 meses la fecha de inicio");
                        }
                        else MessageBox.Show("La semana elegida no se encuentra disponible");
                    }
                    else MessageBox.Show("La fecha de inicio es incorrecta");
                }       
            }
            else MessageBox.Show("La propiedad elegida es errónea");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
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
            var nombreTrimmeado = st.Substring(0,st.IndexOf(",")) ?? string.Empty;
            foreach (Propiedad casa in propie)
            {
                if (casa.nombre == nombreTrimmeado)                
                    return casa;                
            }
            return null;
        }       
    }
}
