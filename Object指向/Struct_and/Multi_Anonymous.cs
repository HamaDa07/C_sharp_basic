using System;

namespace Multi_Anonymous
{
    class Multi_Anonymous
    {
        static void Main(string[] args)
        {
            var info = new { name = "ジョン", age = 22 ,weight=45 };
            Console.WriteLine(info.name);
            Console.WriteLine(info.age);

            //エラー　→　info.weight = 33;

            var info2 = new { info.name, info.age, info.weight };


            Console.WriteLine(info.weight);

        }
    }
}
