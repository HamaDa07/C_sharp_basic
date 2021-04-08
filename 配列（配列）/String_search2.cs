using System;

namespace String_search2
{
    class String_search2
    {
        static void Main(string[] args)
        {
            var str1 = "ABCDEF";
            Console.WriteLine(str1.Substring(3,2));//DE
            // A B C D E F
            //  1 2 3 4 5 

            var str2 = "D://個人画像//horie.jpg";
            Console.WriteLine(str2.Substring(str2.LastIndexOf(".") + 1));//jpg
            Console.WriteLine(str2.Substring(str2.LastIndexOf(".")));//.jpg

        }
    }
}
