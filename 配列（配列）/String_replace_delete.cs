using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args, int num0)
        {
            string before = "あいうえお";
            string after = before.Replace("うえ", "");
            Console.WriteLine(after);
            // 出力：あいお
        }


    }

}
