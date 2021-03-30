using System;

namespace Hairetu_loop
{
    class Hairetu_loop
    {
        static void Main(string[] args)
        {
            string[] team = { "勇者", "戦士", "魔法使い" };
            Console.WriteLine(team[0]);
            Console.WriteLine(team[1]);
            Console.WriteLine(team[2]);

            //Lengthメッソドは、配列の要素数を調べるメッソド    
            for (var i = 0; team.Length < 3; i++)
            {
                Console.WriteLine(team[i]);
            }


        }
    }
}
