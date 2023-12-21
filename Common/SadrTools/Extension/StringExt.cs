using System.Runtime.Remoting.Channels;

namespace SadrTools.Extension
{
    public static class StringExt 
    {
        public static bool IsNullOrEmptyOrZero(this string str)
        {
            return (str is null) || (str == string.Empty) || str.Length == 0 || str.Equals("0");
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return (str is null) || (str == string.Empty) || str.Length == 0 ;
        }


        /// <summary>
        /// حذف کاراکتر آخر
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(this string str, int length = 1)
        {
            return str.Substring(0, str.Length - length);
        }



        public static int ToInt(this string str)
        {
            if (str.IsNullOrEmpty())
                throw new System.Exception("مقدار ورودی وارد نشده است ");
                
           bool hasParsed = int.TryParse(str, out int result);

            if(hasParsed)
                return result;
            throw new System.Exception("مقدار ورودی قابل تبدیل به عدد نیست ");
        }
    }
}