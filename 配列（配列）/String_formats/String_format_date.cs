using System;
using System.Globalization;//CultureInfoを使う

namespace String_format_date
{
    class Program
    {
        static void Main(string[] args)
        {
            //通貨デンマーク:12.345,00 kr. {C}は、通貨表記
            Console.WriteLine(string.Format(new CultureInfo("da-DK"),"通貨デンマーク:{0:C}",12345));
            //クラスは、 CultureInfo 特定のカルチャに関連付けられた言語、サブ言語、国 / 地域、暦、規則などのカルチャ固有の情報を提供します。

            double num = 0.1234;
            Console.WriteLine(String.Format("{0:P}", num));


        }
    }
}
