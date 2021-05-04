using System;

namespace Method_引数
{
    class Method_引数
    {
        static void Main(string[] args)
        {
            int ans1 = Add(3, 4);
            Console.WriteLine(ans1);//7

            int num1 = 3;
            int num2 = int.Parse(Console.ReadLine());
            int ans2 = Add(num1, num2);
            Console.WriteLine(ans2);
        }

        static int Add(int x,int y)
        {
            return x + y;
        }
    }
}
