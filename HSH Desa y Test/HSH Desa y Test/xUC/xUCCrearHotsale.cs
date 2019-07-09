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


namespace HSH_Desa_y_Test.xUC
{
    public partial class xUCCrearHotsale : DevExpress.XtraEditors.XtraUserControl
    {
        private List<Propiedad> propie;
        private List<string> semanas = new List<string>();
        public xUCCrearHotsale()
        {
            InitializeComponent();
        }

        public void inicializar()
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
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

            llenarConSemanas(this, null);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Propiedad st = encontrarCual(comboBox1.AccessibilityObject.Value);
            DialogResult m = MessageBox.Show("Desea crear la subasta?", "Crear Subasta", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                if (st!=null)
                {
                    if (DateTime.Parse(maskedTextBox2.Text).CompareTo(DateTime.Now) >= 0)
                    {
                        int numeroSemana = Int32.Parse(comboBox3.SelectedItem.ToString().GetCharsBefore(" - "));
                        if (st.EstaLibre(numeroSemana, (int)comboBox2.SelectedItem, true))
                        {
                            if (Semanizador.LunesDeSemana((int)comboBox2.SelectedItem, numeroSemana).CompareTo(DateTime.Parse(maskedTextBox2.Text).AddDays(7)) > 0)
                            {
                                HotSale nuevoHotSale = new HotSale(DateTime.Parse(maskedTextBox2.Text), DateTime.Parse(maskedTextBox2.Text).AddDays(7), maskedTextBox1.AccessibilityObject.Value, numeroSemana, (int)comboBox2.SelectedItem, st);

                                st.HotSales.Add(nuevoHotSale);

                                nuevoHotSale.guardarEnBD();

                                this.inicializar();
                                MessageBox.Show("Se creó el hotsale con éxito");
                            }
                            else MessageBox.Show("La semana elegida debe superar la fecha de fin de hotsale, la cual es 7 dias a partir de la fecha de inicio.");
                        }
                    }
                    else MessageBox.Show("La fecha de inicio es incorrecta");
                }
                else MessageBox.Show("La propiedad elegida es errónea");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            comboBox3.SelectedIndex = 0;
            if (comboBox1.Items.Count != 0) comboBox1.SelectedIndex = 0;
            if (comboBox2.Items.Count != 0) comboBox2.SelectedIndex = 0;
        }

        private List<Propiedad> llenarConPropiedades()
        {
            using (ContextoEntity conec = new ContextoEntity())
            {
                return conec.Propiedads
                    .Include(p => p.subastas)
                    .Include(p => p.HotSales)
                    .Include(p => p.ReservaDirectas)
                    .ToList();
            }
        }

        private void llenarConSemanas(object sender, EventArgs e)
        {
            semanas.Clear();
            for (int i = 1; i <= 52; i++)
            {
                if (Semanizador.LunesDeSemana((int)comboBox2.SelectedItem, i).CompareTo(DateTime.Today) <= 0) continue;
                semanas.Add(string.Concat(i.ToString(), Semanizador.LunesDeSemana((int)comboBox2.SelectedItem, i).ToString(" - (dd/MM/yyyy)")));
            }
            comboBox3.DataSource = null;
            comboBox3.DataSource = semanas;
            comboBox3.SelectedIndex = 0;
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

