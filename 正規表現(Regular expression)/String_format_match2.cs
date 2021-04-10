using System;
using System.Text.RegularExpressions;
namespace String_format_match2
{
    class String_format_match2
    {
        static void Main(string[] args)
        {   
            var str1 = new[] { "book", "BOOK", "Book", "xyz" };
            var match1_1 = new Regex(@"[a-z]"); //a-eのもじ //数字の文字列の場合は[0-9]
                                                //上の方法だと「BOOK以外は、Trueになる
            var match1_2 = new Regex(@"[a-eA-E]");// a-e もしくは A-E

            foreach (var ans1_1 in str1)
            {
                Console.Write(ans1_1 + ":");//
                Console.WriteLine(match1_1.IsMatch(ans1_1) ? ans1_1 : "アンマッチ");
            }//book:book  BOOK:アンマッチ  Book:Book  xyz:xyz

            Console.WriteLine();
            foreach (var ans1_2 in str1)
            {
                Console.Write(ans1_2 + ":");//
                Console.WriteLine(match1_2.IsMatch(ans1_2) ? ans1_2 : "アンマッチ");
            }//book:book    BOOK:BOOK   Book:Book   xyz:アンマッチ

                
            //任意の文字列にマッチするとき/////
            Console.WriteLine();
            var str2 = new[] {"hot","heat","hit","heavenstar","hitting"};
            var match2_1 = new Regex(@"h.t");//.は任意の1文字
            var match2_2 = new Regex(@"h..t");//..は任意の2文字

            foreach(var ans2_1 in str2){
                Console.Write(ans2_1+":");
                Console.WriteLine(match2_1.IsMatch(ans2_1) ? ans2_1 : "アンマッチ");
            }//hot:hot  heat:アンマッチ  hit:hit   heavenstar:アンマッチ    hitting:hitting

            foreach(var ans2_2 in str2)
            {
                Console.Write(ans2_2+":");
                Console.Write(match2_2.IsMatch(ans2_2) ? ans2_2:"アンマッチ");
            }//hot:アンマッチ    heat:heat   hit:アンマッチ   heavenstar:アンマッチ    hitting:hitting
        }
    }
}
