using System;

namespace String
{
    class String_word_change
    {
        static void Main(string[] args)
        {

            var str1 = "A,B,C,D";
            var str2 = str1.Replace("A", "0");

            Console.WriteLine(str1);//A,B,C,D
            Console.WriteLine(str2);//0,B,C,D
        }
    }
}
