using System;

namespace Method_scope2
{
    class Method_scope2
    {
        static void Main(string[] args)
        {   
            string message1 = "Hello ";
            SayHello(message1);
            //Hello Hello C_sharp
        }
        static string SayHello(string message1)
        {   
            
            string message2 = "Hello";
            message2 += message1;
            message2 += " ";
            message2 += "C_sharp";
            Console.WriteLine(message2);
            return message2;
            //戻り値を返さないとエラーになるかも
        }
    }
}
