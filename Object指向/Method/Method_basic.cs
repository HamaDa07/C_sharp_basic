using System;

namespace MEthod_basic
{
    class Method_basic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SayHello();
            SayHello();
            //Hello World!
            //Hello C_sharp  Hello C_sharp
        }

        static void SayHello()
        {
            Console.Write("Hello C_sharp"+"  ");
        }
    }
}
