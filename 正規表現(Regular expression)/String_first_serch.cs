using System;
using System.Text.RegularExpressions;

namespace String_format_serch2
{
    class String_first_serch
    {
        static void Main(string[] args)
        { 
             var str="自宅の電話番号は、080-000-0000です。携帯は、080-0000-0000です。";
            var rgx = new Regex(@"\d{2,4}-\d{2,4}-\d{4}");

            var result = rgx.Matches(str);//Matchesメッソドは、マッチした文字列の配列にアクセスできる
            
            Console.WriteLine(result.Count);//Countでマッチした個数を表示できる
            //2 
            Console.WriteLine(result[0]);//
            //080-000-0000
            
            foreach(Match m in result)
            {
                Console.WriteLine($"位置:{m.Index} 長さ:{m.Length} マッチ文字列{m.Value}");
            }
        }//位置:9 長さ:12 マッチ文字列080-000-0000
        //位置:28 長さ:13 マッチ文字列080-0000-000
    }
}
