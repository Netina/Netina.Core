using System;
using System.Collections.Generic;
using System.Text;

namespace Netina.Core.Extensions
{
    public static class DateTimeExtensions
    {
        public static string GetPersianDayOfWeek(this DayOfWeek dayOfWeek)
        {

            switch (dayOfWeek)
            {
                case DayOfWeek.Friday:
                    return "جمعه";
                case DayOfWeek.Monday:
                    return "دوشنبه";
                case DayOfWeek.Saturday:
                    return "شنبه";
                case DayOfWeek.Sunday:
                    return "یکشنبه";
                case DayOfWeek.Thursday:
                    return "پنج شنبه";
                case DayOfWeek.Tuesday:
                    return "سه شنبه";
                case DayOfWeek.Wednesday:
                    return "چهارشنبه";
            }

            return "";
        }
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public static int DifferenceByDay(DateTime originDateTime, DateTime destDateTime)
        {
            return (int)(destDateTime - originDateTime).TotalDays;
        }

        public static int DifferenceByHoure(DateTime originDateTime, DateTime destDateTime)
        {

            return (int)(destDateTime - originDateTime).TotalHours;
        }
    }
}
