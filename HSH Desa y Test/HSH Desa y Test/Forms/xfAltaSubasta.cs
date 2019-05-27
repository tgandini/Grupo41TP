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
                        int i = GetIso8601WeekOfYear(DateTime.Now);
                        DateTime fechaSemana;
                        if (i > int.Parse(maskedTextBox1.Text)) fechaSemana = FirstDateOfWeekISO8601(DateTime.Now.Year + 1, int.Parse(maskedTextBox1.Text));
                        else fechaSemana = FirstDateOfWeekISO8601(DateTime.Now.Year, int.Parse(maskedTextBox1.Text));
                        if (fechaSemana > DateTime.Parse(maskedTextBox2.Text).AddMonths(6))
                        {
                            subasta nuevaSubasta = new subasta(st, (int)numericUpDown1.Value, maskedTextBox1.AccessibilityObject.Value, DateTime.Parse(maskedTextBox2.AccessibilityObject.Value));
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
            foreach (Propiedad casa in propie)
            {
                if (casa.nombre == st)                
                    return casa;                
            }
            return null;
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // Seriously cheat.  If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }
    }
}
