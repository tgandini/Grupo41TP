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
using System.Data.Entity;


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
                iden.Add(casa.nombre);
            }
            iden.Sort();
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
                //DialogResult m = MessageBox.Show("Desea crear la subasta?","Crear Subasta", MessageBoxButtons.YesNo);
                //if (m == DialogResult.Yes)
                //{
                    if (DateTime.Parse(maskedTextBox2.Text) >= (DateTime.Now))
                    {
                        DateTime fechaSemana = Semanizador.LunesDeSemana(int.Parse(comboBox2.SelectedItem.ToString()), int.Parse(numericUpDown1.Value.ToString()));                 
                        if (st.EstaLibre(decimal.ToInt32(numericUpDown1.Value), fechaSemana.Year,true))
                        {
                            if (fechaSemana > DateTime.Parse(maskedTextBox2.Text).AddMonths(6))
                            {
                                subasta nuevaSubasta = new subasta((int)comboBox2.SelectedItem, (int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value), st.id);

                                st.subastas.Add(nuevaSubasta);

                                //ToDo: No se puede guardar la propiedad con la subasta adentro, ver de dar de alta solo la subasta
                                nuevaSubasta.guardarEnBD();
                                
                                this.inicializar();
                                MessageBox.Show("Se creó la subasta con éxito");
                            }
                            else MessageBox.Show("La semana elegida debe superar en 6 meses la fecha de inicio");
                        }
                      
                }
                    else MessageBox.Show("La fecha de inicio es incorrecta");
                //}       
            }
            else MessageBox.Show("La propiedad elegida es errónea");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            numericUpDown1.Value = 1;
            if (comboBox1.Items.Count!=0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count!=0) comboBox2.SelectedIndex = 0;
        }

        private List<Propiedad> llenarConPropiedades()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.Propiedads
                    .Include(p=> p.subastas)
                    .Include(p=> p.HotSales)
                    .Include(p=>p.ReservaDirectas)
                    .ToList();
            }
        }

        private Propiedad encontrarCual(string st)
        {
            //var nombreTrimmeado = st.Substring(0,st.IndexOf(",")) ?? string.Empty;
            foreach (Propiedad casa in propie)
            {
                if (casa.nombre == st)                
                    return casa;                
            }
            return null;
        }
    }
}
