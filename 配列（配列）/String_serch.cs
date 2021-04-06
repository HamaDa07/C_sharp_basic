using System;

namespace String_serch
{
    class String_serch
    {
        static void Main(string[] args)
        {
            var str = "にわにはにわにわとりがいる";
            var str1 = "WINGSプロジェクト";

            //型名.検索開始位置("文字",範囲)  str.IndexOf("にわ");
            /*文字列を先頭から検索し、見つかった場合
             *先頭文字を0として値を返す*/

            Console.WriteLine(str.IndexOf("にわ"));// 結果:0

            //文字が含まれているかどうかを返す
            Console.WriteLine(str1.Contains("プロ"));//True
            Console.WriteLine(str.Contains("aaaaa"));//false

        }
    }
}
