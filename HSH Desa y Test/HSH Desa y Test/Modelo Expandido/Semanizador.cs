using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSH_Desa_y_Test.Modelo_Expandido
{
    /*
    Clase que se crea con el motivo de poder pasarle como parámetro un DateTime y te tira la semana del año en la que está.
    Análogamente si le ingresás una semana y un año, tiene 2 mensajes que entiende y te devuelve o el primer instante de esa
    semana o el último (Ya sea para encontrar límites inf o sup de la reserva)
        */
    class Semanizador
    {
        public static int getSemanaDelAño(DateTime time)
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
        public static DateTime LunesDeSemana(int year, int weekOfYear)
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
        public static DateTime ultimoDíaDeSemana(int year, int weekOfYear)
        {
            return Semanizador.LunesDeSemana(year, weekOfYear + 1);
        }

        public static DateTime semanaSegunFechaInicio(DateTime fechaInicio, int sem)
        {
            DateTime fechaSemana;
            if (Semanizador.getSemanaDelAño(fechaInicio) > sem) fechaSemana = Semanizador.LunesDeSemana(fechaInicio.Year + 1, sem);
            else fechaSemana = Semanizador.LunesDeSemana(fechaInicio.Year, sem);
            return fechaSemana;
        }

    }

}
