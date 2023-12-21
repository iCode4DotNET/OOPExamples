namespace SadrTools.Utility
{
    public static class NumericHelper
    {

        // signed 
        // unsigned

        // signed bit سمت چپ ترین

        // 1 1 1 1  1 1 1 1 (1+2+4+8+16+32+64+128) = 255
        // 255- 128 = 127

        public static ulong CalculateFactorial(byte number)
        {

            // 5! = 5*4*3*2*1

            ulong factorial = 1;

            for (byte i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static ulong CalculateFactorial_Recursive(byte number)
        {
            // 5! = 5 * 4!

            // آدرس بازگشت در حافظه استک پشته ذخیره میشود

            // Stack - FILO - LIFO

            // QUEUE : FIFO - LILO - FCFS


            // STACK OVERFLOW
            if (number < 2)
                return 1;

            return number * CalculateFactorial_Recursive((byte)(number - 1));


            // تمرین : متد های دلخواه به روش بازگشتی 

            
        }
    }
}
