using System;
using System.Text.RegularExpressions;
namespace String_format_repeat
{
    class String_format_repeat
    {
        static void Main(string[] args)
        {   
           ///////0文字以上の文字の繰り返し////////
            var str1 = new[] {"sn","son","con","soon","sooon","soooon"};
            var match1 = new Regex(@"so*n"); // X* 0文字以上の "o"
            foreach(var ans1 in str1)
            {
                Console.Write(ans1 + ":");
                Console.WriteLine(match1.IsMatch(ans1)?ans1:"アンマッチ");
            }//sn:sn    son:son con:アンマッチ   soon:soon      
            Console.WriteLine();// sooon:sooon  soooon:soooon

            //////1文字以上の文字の繰り返し///////
            var match2 = new Regex(@"so+n"); // X+　1文字以上の "o"
            foreach(var ans2 in str1)
            {
                Console.Write(ans2 + ":");
                Console.WriteLine(match2.IsMatch(ans2) ? ans2:"アンマッチ") ;
            }//sn:アンマッチ     son:son     con:アンマッチ   
            Console.WriteLine();//soon:soon     sooon:sooon  soooon:soooon

            //////0 or 1 文字の繰り返し////////
            var match3 = new Regex(@"so?n"); // X? 0もしくは1の "o"
            foreach(var ans3 in str1)
            {
                Console.Write(ans3 + ":");
                Console.WriteLine(match3.IsMatch(ans3) ? ans3 : "アンマッチ");
            }//sn:sn    son:son con:アンマッチ   
            Console.WriteLine();//soon:アンマッチ    sooon:アンマッチ   soooon:アンマッチ

            ///// N文字の繰り返し///////
            var match4 = new Regex(@"so{2}");//X[N] N(2)文字の "o"
            foreach(var ans4 in str1)
            {
                Console.Write(ans4 + ":");
                Console.WriteLine(match4.IsMatch(ans4) ? ans4 : "アンマッチ");
            }//sn:アンマッチ  son:アンマッチ   con:アンマッチ  
            Console.WriteLine();// soon:soon    sooon:sooon  soooon:soooon

            ///// N文字以上の繰り返し/////
            var match5 = new Regex(@"so{2,}");//X{N,} N(2)文字以上の "o"
            foreach(var ans5 in str1)
            {
                Console.Write(ans5 + ";");
                Console.WriteLine(match5.IsMatch(ans5) ? ans5:"アンマッチ") ;
            }//sn;アンマッチ     son;アンマッチ   con;アンマッチ  
            Console.WriteLine();// soon;soon    sooon;sooon   soooon;soooon

            /////M～N文字の繰り返し
            var match6 = new Regex(@"so{2,3}n");
            foreach(var ans6 in str1)
            {
                Console.Write(ans6 + ":");
                Console.Write(match6.IsMatch(ans6)?ans6:"アンマッチ");
            }  //sn: アンマッチ      son: アンマッチ      con: アンマッチ 
            Console.WriteLine(); // soon: soon  sooon: sooon     soooon: アンマッチ
        }
    }
}
