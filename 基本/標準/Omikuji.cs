using System;

namespace Omikuji1
{
    class Omikuji
    {
        static void Main()
        {
            var random = new Random();
            var omikuji = random.Next(1, 11); //  1 < =x <11

            //Console.WriteLine(omikuji);
            if (omikuji == 1)
            {
                Console.WriteLine("大吉");
            }
            else if (omikuji == 2)
            {
                Console.WriteLine("中吉");
            }
            else if (omikuji <= 4)
            {
                Console.WriteLine("小吉");//3,4
            }
            else if (omikuji <= 7)
            {
                Console.WriteLine("凶");//5.6.7
            }
            else
            {
                Console.WriteLine("大凶");
            }
        }
    }
}
