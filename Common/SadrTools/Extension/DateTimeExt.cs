using System.Globalization;
using System;

namespace SadrTools.Extension
{
    public static class DateTimeExt
    {
        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate(this DateTime date, char separator = '/')
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }
    }

   
}
