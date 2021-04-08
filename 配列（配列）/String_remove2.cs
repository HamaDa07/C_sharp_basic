using System;

namespace String_remove2
{
    class Program
    {
        static void Main(string[] args)
        {

            var str1 = "ABC---DEF";
            Console.WriteLine("最初の文字列" + str1);

            Console.WriteLine("{0}", str1.Remove(3));
            Console.WriteLine("{0}", str1.Remove(3, 3));
        }
    }
}
