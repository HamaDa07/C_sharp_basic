using System;
using System.IO;
namespace File_text_write
{
    class File_text_write
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log")) 
            {
                writer.WriteLine(DateTime.Now.ToString());
                //2021/06/08 19:58:23
                //成功して、メモ帳からファイルを開くと↑のような記述
                writer.WriteLine("成功!!!");
                //成功!!!
                int a = 10;
                int b = 5;
                string c = "数字文字列も可能";

                writer.WriteLine("{0}+{1}={2}  {3}",a,b,a+b,c);
                //10+5=15  数字文字列も可能
            }
        }
    }
}
