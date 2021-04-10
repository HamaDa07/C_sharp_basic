using System;
using System.Text.RegularExpressions;//RegexクラスとIsMatchメッソドを使う
namespace Word_format_match1
{
    class Word_format_match1
    {
        static void Main()
        { 
            var str1= new []{"soon","soft","Soon","ssss"};

           /*/////特定の文字列にマッチ//////*/
           var match1= new Regex(@"soon");

            foreach (var ans1 in str1)
            {
                Console.Write(ans1 + ":");
                Console.WriteLine(match1.IsMatch(ans1) ? ans1 : "アンマッチ");
            }//soon:soon   soft:アンマッチ  Soon:アンマッチ  ssss:アンマッチ
            Console.WriteLine();

            //////*いずれかの文字列にマッチ//////*/
            var str2 = new[]{ "hill", "Hill", "hello","HILL"};
            var match2 = new Regex(@"[hi]");//[AB]だと、A or Bの時にマッチする

            foreach (var ans2 in str2)
            {   Console.Write(ans2 + ":");
                Console.WriteLine(match2.IsMatch(ans2) ? ans2 :"アンマッチ");//大文字だとマッチしない
            }//hill:hill  Hill: Hill  hello:hello   HILL:アンマッチ

            Console.WriteLine();
            var match3 = new Regex(@"^[h]"); // not [h]  //
            foreach( var ans3 in str2)
            {
                Console.Write(ans3 + ":");
                Console.Write(match3.IsMatch(ans3) ? ans3:"アンマッチ");
            }//hill: hill   Hill: アンマッチ hello: hello    HILL: アンマッチ
        }
    }
}
