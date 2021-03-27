// 変数を使う
using System;

namespace Hensuu1
{
    public class Program
    {
        public static void Main()
        {
            var player = "勇者";//var変数は、自動で型名を認識してくれる
            Console.WriteLine(player);

            Console.WriteLine(player + "荒野を歩いていた");
            Console.WriteLine(player + "は、モンスターと戦った");

            player = "戦士";
            Console.WriteLine(player + "は、モンスターをたおした");
        }
    }
}
