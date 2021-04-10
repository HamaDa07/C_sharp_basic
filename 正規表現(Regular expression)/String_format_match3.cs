using System;
using System.Text.RegularExpressions;
namespace String_format_match3
{
    class String_format_match3
    {
        static void Main(string[] args)
        {
            //////先頭を検出///////
            var str1 = new[] { "plan", "splash", "apple", "apples" };
            var match1_1 = new Regex(@"^pla");//^ABCで、先頭の文字 ABC

            foreach(var ans1_1 in str1)
            {
                Console.Write(ans1_1+":");
                Console.WriteLine(match1_1.IsMatch(ans1_1) ? ans1_1 : "アンマッチ");
            }// plan:plan    splash: アンマッチ   apple: アンマッチ   apples: アンマッチ

            /////末尾を検出//////
            Console.WriteLine();
            var match1_2 = new Regex(@"ple$");//XYZ$で最後の文字XYZ
            foreach(var ans1_2 in str1)
            {
                Console.Write(ans1_2+":");
                Console.Write(match1_2.IsMatch(ans1_2)?ans1_2:"アンマッチ");
            }//plan:アンマッチ   splash:アンマッチ   apple:apple    apples:アンマッチ

            var str2 = new[] { "soon" };
        }
    }
}
