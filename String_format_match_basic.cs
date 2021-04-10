using System;
using System.Text.RegularExpressions;//IsMatchを使う

namespace String_format_match_basic
{
    class String_format_match_basic
    {
        static void Main(string[] args)
        {

            var tel = new[] { "080-0000-0000", "084-000-0000","184-0000"};
            var match = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");
            // 2～4桁の数字,2～4桁の数字,4桁の数字

            foreach (var i in tel)
            {
                //Console.Write(match.IsMatch(i+"  ") ? i: "アンマッチ");//空白が意味ない...
                Console.WriteLine(match.IsMatch(i + "  ") ? i : "アンマッチ");

                /*080-0000-0000     //Ismatch
                  084-000-0000      //matchしたときに、tel配列の中身(電話番号)を表示
                  アンマッチ*/      //unmatchのときに"アンマッチと表示"

            }
        }   
    }
}
