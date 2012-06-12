
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace software
{
    class GH_Date
    {
        public static DateTime GtoH(DateTime gDate)
        {
            int year, month, day, tempMonth, tempDay;
            year = gDate.Year;
            month = gDate.Month;
            day = gDate.Day;
            //setting year
            if (month < 3 || (month == 3 && day < 21))
                year = year - 622;
            else
                year = year - 621;

            DateTime tempDate = new DateTime(year, 1, 1);
            tempDay = day;
            tempMonth = month;
            day = 11;
            month = 10;
            if (year % 4 == 0)
                day--;

            while (!(tempDate.Day == tempDay && tempDate.Month == tempMonth))
            {
                tempDate = tempDate.AddDays(1);
                day++;
                if (day == 32 && month < 7)
                {
                    day = 1;
                    month++;
                }
                else if (day == 31 && (month > 6 && month < 12))
                {
                    day = 1;
                    month++;
                }
                else if (month == 12 && day == 30)
                {
                    day = month = 1;
                }

            }
            return new DateTime(year, month, day);
        }

        public static DateTime HtoG(DateTime hDate)
        {
            int year, month, day, tempMonth, tempDay;
            year = hDate.Year;
            month = hDate.Month;
            day = hDate.Day;
            //setting year
            if (month < 10 || (month == 10 && day < 11))
                year = year + 621;
            else
                year = year + 622;

            DateTime tempDate = new DateTime(year, 3, 21);
            tempDay = day;
            tempMonth = month;
            day = 1;
            month = 1;
            if (year % 4 == 0)
                day--;

            while (!(day == tempDay && month == tempMonth))
            {
                tempDate = tempDate.AddDays(1);
                day++;
                if (day == 32 && month < 7)
                {
                    day = 1;
                    month++;
                }
                else if (day == 31 && (month > 6 && month < 12))
                {
                    day = 1;
                    month++;
                }
                else if (month == 12 && day == 30)
                {
                    day = month = 1;
                }

            }
            return new DateTime(tempDate.Year, tempDate.Month, tempDate.Day);
        }

        public static string getHDayOfWeek(DateTime gDate)
        {
            DateTime temp = HtoG(gDate);
            switch (temp.DayOfWeek)
            {
                case DayOfWeek.Friday:
                    return "شنبه";
                case DayOfWeek.Monday:
                    return "سه شنبه";
                case DayOfWeek.Saturday:
                    return "یکشنبه";
                case DayOfWeek.Sunday:
                    return "دوشنبه";
                case DayOfWeek.Thursday:
                    return "جمعه";
                case DayOfWeek.Tuesday:
                    return "چهار شنبه";
                case DayOfWeek.Wednesday:
                    return "پنج شنبه";
                default:
                    return "";
            }
        }
    }
}
