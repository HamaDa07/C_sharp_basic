using System;
using System.Globalization;

namespace String_format
{
    class String_format
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0}は{1},{2}歳です", " おれ", "男", "3"));// おれは男,3歳です

            Console.WriteLine(string.Format("{0}と{0}と{1}", "おれ", "あなた"));//おれとおれとあなた

            Console.WriteLine(string.Format("日付:{0:D}", DateTime.Now));//日付:2021年4月6日

            //{0}桁数分を0で置換、{D}は、10進数表記

        }
    }
}
