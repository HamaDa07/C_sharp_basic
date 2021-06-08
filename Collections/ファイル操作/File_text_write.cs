using System;
using System.IO;
namespace File_text_write
{
    class File_text_write
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log", append: true))
            {//@を忘れずに


                //append : true:追記する　false(上書きする)
                // 変数名.WriteLine("文字列、数字、データ")
                writer.WriteLine(DateTime.Now.ToString());
                writer.WriteLine("成功!!!");
                int a = 10;
                int b = 5;
                string c = "数字文字列も可能";

                var lines = new[] { "A", "B" };
                writer.WriteLine("{0}+{1}={2}  {3}", a, b, a + b, c); 
                writer.Close();
                //別の操作をするは、ファイルを必ず閉じる(例外処理が起こるため)

                ///やり方その2
                File.WriteAllLines(@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log",lines);

                writer.Close();
                //エラー対策で、ファイルを閉じる関数

                //2021/06/08 19:58:23
                //成功!!!
                //10+5=15 数字文字列も可能
            }

            //apend : false のとき     (上書き)
            //2021/06/08 21:59:28
            //成功!!!
            //10 + 5 = 15  数字文字列も可能

            //apemd : ture のとき      (追記)
            /*2021/06/08 22:05:59
            成功!!!
            10+5=15  数字文字列も可能
            */

            //最終的なもの appendがtrueでも　Fileで操作すると上書きされてしまう
            /*A
            B*/

        }
    }
}
