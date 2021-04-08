using System;

namespace String_remove
{
    class String_remove
    {
        static void Main(string[] args)
        {

            var str1 = "ABCDEFG";
            Console.WriteLine("元の文字列" + str1);
            Console.WriteLine();

            var str2 = str1.Remove(0, str1.IndexOf("C"));//Cより前を消す
            Console.WriteLine(str2);//CDEFG

            var str0 = str1.Remove(1,str1.IndexOf("C"));
            Console.WriteLine(str0);//ADEFG
            var str3 = str1.Remove(2, str1.IndexOf("C"));
            Console.WriteLine(str3);//ABEFG


            str2 = str2.Remove(str2.IndexOf('F'));//Fよりあとを消す
            Console.WriteLine(str2);//CDE
        }
    }
}
