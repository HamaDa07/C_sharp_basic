using System;

namespace Scan_basic
{
    class Scan_basic
    {
        static void Main(string[] args)
        {
            var data = "";//空の文字列
            data = Console.ReadLine();
            Console.WriteLine("hello" + data);

            var number = 0;
            number = int.Parse(Console.ReadLine());//Parseは、数字を読み込むメッソド
            Console.WriteLine(number * 2);

        }
    }
}
