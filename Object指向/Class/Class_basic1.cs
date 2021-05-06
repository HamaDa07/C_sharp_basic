using System;

namespace Class_basic1
{
    class Class_basic1
    {
        static void Main(string[] args)
        {
            var player = new Second();
            player.Walk();//SecondクラスのWalkメッソドからこんにちは
            // 変数 = new クラス名
            // 変数.メッソド
        }
    }
    class Second
    {
        public void Walk()
        {
            Console.WriteLine("SecondクラスのWalkメッソドからこんにちは");
        }
    }
}
