using System;

namespace Goto_basic
{
    class Goto_basic
    {
        static void Main(string[] args)
        {
            goto A;          // goto 任意のラベル;
            Console.WriteLine("ここはスキップされる");

            A://任意のラベル:
            Console.WriteLine("コードが終了した");

        }
    }
}
