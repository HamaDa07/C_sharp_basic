using System;
using System.Text;
namespace String_equal
{
    class Program
    {
        static void Main(string[] args)
        {

            var str1 = new StringBuilder("あいう");
            var str2 = new StringBuilder("あいう");

            Console.WriteLine(str1 == str2);//false
            Console.WriteLine(str1.Equals(str2));//true

            /*別々に生成されたオブジェクトなので、同一でないとみなされ
             * それを回避するためのEqualsメッソド*/
        }
    }
}
