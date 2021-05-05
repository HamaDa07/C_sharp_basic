using System;

namespace Method_引数_Rockon
{
    class Method_引数_Rockon
    {
        static void Main(string[] args)
        {
            SayHello(greeting: "GoodMornig1 ");//GoodMornig1 ジョン
            SayHello(name: "トム2 ");//Hello トム2
            SayHello(name: "トムが先3", greeting:"やあ!" );//やあ!トムが先3
        }
        
        static void SayHello(string greeting ="Hello ",string name = "ジョン")
        {
            Console.WriteLine(greeting + name);
        }
    }
}
