using System;

namespace String_split
{
    class String_split
    {
        static void Main()
        {
            var player_1 = "勇者";
            var player_2 = "魔法使い";

            Console.WriteLine(player_1);
            Console.WriteLine(player_2);

            string[] team = { "戦士", "忍者" };


            //文字列の配列の要素の連結
            //配列の内容を指定した文字で区切りながら各
            //要素を結合できる  (strubg.Join)

            Console.WriteLine(string.Join(".", team));
            //戦士.忍者
            Console.WriteLine(team[0]); //戦士
            Console.WriteLine(team[1]);//忍者
        }
    }
}
