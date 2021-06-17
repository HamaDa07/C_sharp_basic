using System;
using System.IO;

namespace Try_catch_basic1
{
    class Try_catch_basic1
    {
        static void Main(string[] args)
        {

            //例外なし (読み取るためのコード)
            using (var reader1 = new StreamReader(@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log"))
            {
                Console.WriteLine(reader1.ReadToEnd());
                /*A
                  B*/
            }

            try
            {
                //例外あり (読み込むはずのファイルがない)
                using (var reader2 = new StreamReader(@"D:\雑多\ちょっとしたもの\プログラミング関連\fake.txt"))
                {
                    Console.WriteLine(reader2.ReadToEnd());

                }
            }
            catch (FileNotFoundException ex)//exは変数名 必要ない時もある
            {
                Console.WriteLine("ファイルが見つかりませんでした");
                Console.WriteLine(ex.StackTrace);
                //StackTraceは、例外を発生するまでに呼び出したメッソドの呼び出し履歴を記録する
            }
            /*ファイルが見つかりませんでした
   at System.IO.FileStream.ValidateFileHandle(SafeFileHandle fileHandle)
   at System.IO.FileStream.CreateFileOpenHandle(FileMode mode, FileShare share, FileOptions options)
   at System.IO.FileStream..ctor(String path, FileMode mode, FileAccess access, FileShare share, Int32 bufferSize, FileOptions options)
   at System.IO.StreamReader.ValidateArgsAndOpenPath(String path, Encoding encoding, Int32 bufferSize)
   at System.IO.StreamReader..ctor(String path)
   at Try_catch_basic1.Try_catch_basic1.Main(String[] args) in C:\Users\ユーザー名\source\repos\C_sharp_basic2\Try_catch_basic1\Try_catch_basic1.cs:line 22*/


        }
    }
}
