using System;

namespace For_plus_scan
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("データ個数" + count);

            var data = "";
            for (var i = 0; i < count; i++)
            {
                data = Console.ReadLine();
                Console.WriteLine("hello" + i);
            }

        }
    }
}
