using System;
using System.Text.RegularExpressions;
namespace String_match_string
{
    class String_match_string
    {
        static void Main(string[] args)
        {   
            // "ABC"という文字列の繰り返しパターン
            var words = "ABC";
            var str1 = new[] { "ABC", "ABCABC", "ABCABCABC" };

            var match1 = new Regex(@"(ABC){2,}");//"ABC"という文字列が2回以上のときに表示
            foreach(var ans1 in str1)
            {
                Console.Write(ans1 + ":");
                Console.WriteLine(match1.IsMatch(ans1) ? ans1 : "アンマッチ");
            } //ABC:アンマッチ   ABCABC:ABCABC   ABCABCABC:ABCABCABC


        }
    }
}
