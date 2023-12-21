using System;
using System.Globalization;

namespace SadrTools.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class DateHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToPersianDate(DateTime date)
        {
            // 2023/12/08 ==> 1402/09/17
            // 2023/12/8 ==>  1402/09/07

            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/{pc.GetMonth(date)}/{pc.GetDayOfMonth(date)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToPersianDate2(DateTime date)
        {
            // 2023/12/08 ==> 1402/09/17
            // 2023/12/8 ==>  1402/09/07

            /*
            string tmp = 123;

            string tmp2 = 123.ToString();

            string tmp3 = 123.ToString() + " salam ";

            string tmp4 = 123 + " salam ";
            */

            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}/" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2,'0')}/" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2,'0')}";
      
        }



        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate3(DateTime date, char separator)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }

        /// <summary>
        /// تبدیل به تاریخ شمسی
        /// </summary>
        /// <param name="date">تاریخ میلادی</param>
        /// <param name="separator">جداکننده</param>
        /// <returns>تاریخ شمسی</returns>
        public static string ToPersianDate4(DateTime date, char separator='/')
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date)}{separator}" +
                   $"{pc.GetMonth(date).ToString().PadLeft(2, '0')}{separator}" +
                   $"{pc.GetDayOfMonth(date).ToString().PadLeft(2, '0')}";

        }
    }
}