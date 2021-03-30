using System;

namespace String_add
{
    class String_add
    {
        static void Main(string[] args)
        {
            string[] team = { "勇者", "魔法使い" };
            Console.WriteLine(string.Join("・", team));//勇者・魔法使い


            //文字列の再代入
            team = new string[2];
            team[0] = "戦士";
            team[1] = "忍者";

            //var numer =0;
            // Console.WriteLine(team[numer]);
            Console.WriteLine(team[0]);//戦士
        }

    }
}
