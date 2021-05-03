using System;

namespace Loop_multi_Foreacu
{
    class Loop_multi_Foreach
    {
        static void Main(string[] args)
        {
            string[][] array = {
            new string[] {"勇者", "忍者"},
            new string[] {"武士", "戦士"},
            new string[] {"僧侶", "魔法使い"}
        };

            // foreachで、arrayを出力してみよう
            foreach (string[] team1 in array) //仮変数1を配列として宣言
            {
                foreach (string team2 in team1) //仮変数2の中に、仮変数1を代入
                {
                    Console.Write(team1 + "  ");
                    Console.WriteLine(team2);
                }
            }
            /*  System.String[] 勇者
                System.String[] 忍者
                System.String[] 武士
                System.String[] 戦士
                System.String[] 僧侶
                System.String[] 魔法使い*/
        }
    }
}
