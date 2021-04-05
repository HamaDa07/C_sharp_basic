using System;

namespace Switch_harder
{
    class Switch_multicase
    {
        static void Main(string[] args)
        {
            var number = 0;
            Console.WriteLine("1から5までの数字を入力してください");

            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine((number)+"は奇数です");
                    break;

                case 2:
                case 4:
                    Console.WriteLine((number) + "は偶数です");
                    break;

                default:
                    Console.WriteLine("エラーです");
                    break;

            }
            

        }
    }
}
