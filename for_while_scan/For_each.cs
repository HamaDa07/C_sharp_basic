using System;

namespace Foreach
{
    class For_each
    {
        static void Main(string[] args)
        {
            string[] team = { "勇者", "戦士", "魔法使い" };
            //Console.WriteLine(team.Length);//データの個数   


            foreach (string job in team)
            {
                //変数　in 取り出したい配列（変数）
                Console.WriteLine(job);

            }
        }
    }
}
