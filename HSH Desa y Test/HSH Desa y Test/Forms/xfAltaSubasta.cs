﻿using System;
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
            this.inicializar();
           
        }

        public void inicializar()
        {
            propie = llenarConPropiedades();
            List<string> iden = new List<string>();
            foreach (Propiedad casa in propie)
            {
                iden.Add(string.Format("{0}, ubicada en Ciudad: {1}, dirección:{2}", casa.nombre, casa.ciudad, casa.ubicaciòn));
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
                    if (DateTime.Parse(maskedTextBox2.Text) >= (DateTime.Now))
                    {
                        DateTime fechaSemana;
                        if (Semanizador.getSemanaDelAño(DateTime.Now) > int.Parse(numericUpDown1.Value.ToString())) fechaSemana = Semanizador.LunesDeSemana(DateTime.Now.Year + 1, int.Parse(numericUpDown1.Value.ToString()));
                        else fechaSemana = Semanizador.LunesDeSemana(DateTime.Now.Year, int.Parse(maskedTextBox1.Text));
                        if (fechaSemana > DateTime.Parse(maskedTextBox2.Text).AddMonths(6))
                        {
                            subasta nuevaSubasta = new subasta((int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value));
                            nuevaSubasta.crear();
                        }
                        else MessageBox.Show("La semana elegida debe superar en 6 meses la fecha de inicio");
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
            var nombreTrimmeado = st.Substring(0,st.IndexOf(","));
            foreach (Propiedad casa in propie)
            {
                if (casa.nombre == nombreTrimmeado)                
                    return casa;                
            }
            return null;
        }       
    }
}
