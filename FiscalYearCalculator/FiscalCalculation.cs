using System;
using System.Globalization;

namespace FiscalYearCalculator
{
    public class FiscalCalculation
    {
        public Fiscal GetFiscal(string giveDate)
        { 
            DateTime date;
            if (!DateTime.TryParse(giveDate, out date))
                return null;

     
            return new Fiscal
            {
                Year = getFiscalYear(date),
                Day = getDayofYear(date),
                Woy = getWeekofFiscalYear(date),
                Poy = getPeriod(date),
                Wini = getTheFirstDayOftheWeek(date)
            };

        }

        private int getPeriod(DateTime date)
        {
            if (isNextFicalYear(date))
            {
                return 1;
            }

            var fwoy = getWeekofFiscalYear(date);

            var period = Math.Ceiling(fwoy / 4.0);
            if (fwoy == 53 && period == 14) period = 13;

            return (int)period;
        }
        private int getWeekofFiscalYear(DateTime date)
        {
            if (isNextFicalYear(date))
            {
                return 1;
            }
            
            CultureInfo cul = CultureInfo.CurrentCulture;
            return cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }

        private bool isNextFicalYear(DateTime date)
        {
            return (date.Month == 12 && date.AddDays(7).Year == date.Year + 1 && date.DayOfWeek != DayOfWeek.Sunday);
        }

        private int getFiscalYear(DateTime date)
        {
            int year = date.Year;
            if (isNextFicalYear(date))
            {
                year++;
            }

            return year;
        }

        private int getDayofYear(DateTime date)
        {
            if (isNextFicalYear(date))
            {
                return (int)date.DayOfWeek;
            }

            var firstDayOfYear = new DateTime(date.Year, 1, 1);
            var newYearDayofWeek = Convert.ToInt32(firstDayOfYear.DayOfWeek);

            var fdoy = date.DayOfYear + newYearDayofWeek - 1;

            if (isNextFicalYear(date))
            {
                return (int)date.DayOfWeek;

            }

             return fdoy;
        }

        private DateTime getTheFirstDayOftheWeek(DateTime date)
        {
            var dateOfWeek = date.DayOfWeek;
            switch(dateOfWeek)
            {
                case DayOfWeek.Monday:
                    return date;
                case DayOfWeek.Sunday:
                    return date.AddDays(-6);   //Week Starts from Monday

                default:
                    return date.AddDays(1 - (int)dateOfWeek);
            }
       
          }
       
   }
}
