using System;
using System.IO;
namespace File_Read
{
    class File_Read
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader (@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log"))
            {
                Console.WriteLine(reader.ReadToEnd());          
                /*A
                  B*/
            }
        }
    }
}
