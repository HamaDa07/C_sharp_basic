using System;

namespace String_remove
{
    class String_remove
    {
        static void Main(string[] args)
        {

            var str1 = "ABCEDEFG";

            var str2 = str1.Remove(0, str1.IndexOf("C"));//Cより前を消す
            Console.WriteLine(str2);//CEDEFG

            str2 = str2.Remove(str2.IndexOf('F'));//Fよりあとを消す
            Console.WriteLine(str2);//CEDE
        }
    }
}
