using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactProject.Utils
{
    public static class DateConverter
    {
        public static string ToHejriShamsi(DateTime d)
        {
            PersianCalendar pc = new PersianCalendar();
            return string.Format($"{pc.GetYear(d):0000}/{pc.GetMonth(d):00}/{pc.GetDayOfMonth(d):00}");
        }

        public static DateTime ToMiladi(string date)
        {
            try
            {
                var date_parts = date.Split('/');

                var year =  int.Parse(date_parts[0]);
                var month = int.Parse(date_parts[1]);
                var day =   int.Parse(date_parts[2]);

                if (year < 0) 
                {
                    year = 2000;
                }
                if (month < 0 || month > 12) 
                {
                    month = 12;
                }
                if (day < 0 || day > 30) 
                {
                    day = 20;
                }
                Calendar persian = new PersianCalendar();
                return new DateTime(year, month, day, persian);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
