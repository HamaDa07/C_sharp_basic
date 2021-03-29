using System;

namespace Seireki
{
    class Seireki
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var period = int.Parse(Console.ReadLine());
            var syouwa = 0;

            for (var i = start; i < period + start; i++)
            {
                Console.Write("西暦" + i + "年は");
                syouwa = i - 1925;
                Console.WriteLine("昭和" + syouwa + "年です");

            }
        }
}
