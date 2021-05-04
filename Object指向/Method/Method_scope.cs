using System;

namespace Method_scope
{
    class Method_scope
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Main_a:" + a);

            int num = Sum(a, b);
            Console.WriteLine("Main(Sum) a+b=" + num);
            Console.WriteLine("Main2回目:" + a);
        }//Main_a:10         1番め
         //Sum:Hello_a:3     2番目
         //Main(Sum) a+b=:30 3番目
         //Main2回目:10      4番目


        static int Sum(int x,int y)
        {
            int a = 3;
            Console.WriteLine("Sum:Hello_a:" + a);
            return x + y;//10+20で、30が返り値になる
        }
    }
}
