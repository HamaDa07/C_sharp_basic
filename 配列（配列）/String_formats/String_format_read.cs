using System;

namespace String_format_read
{
    class String_format_read
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力してください");
            var name = Console.ReadLine();
            Console.WriteLine("年齢を入力してください");

            var age = Console.ReadLine();

            Console.WriteLine("{0}です。{1}歳です",name,age);
        }
    }
}
