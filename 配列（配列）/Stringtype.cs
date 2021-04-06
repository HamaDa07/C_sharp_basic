using System;

namespace Stringtype
{
    class Stringtype
    {
        static void Main(string[] args)
        {
            var str1 = "wings";
            var str2 = "Wings";

            Console.WriteLine(str1==str2);//false
            Console.WriteLine(str1.Equals(str2));
            /*別々に生成されたオブジェクトなので、同一でないとみなされ
             * それを回避するためのEqualsメッソド*/


            /*
            //Equals
            Console.WriteLine(str2.Equals(str2, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(str1,str2,StringComparison.OrdinalIgnoreCase));
            */
        }
    }
}
