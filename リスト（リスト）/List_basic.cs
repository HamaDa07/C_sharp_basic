using System;
using System.Collections.Generic;

namespace List_basic
{
    class List_basic
    {
        public static void Main()
        {
            var team = new List<string>();

            //要素を加える
            team.Add("勇者 ");
            team.Add("戦士 ");
            team.Add("魔法使い ");

            //要素を挿入（順番を指定）
            team.Insert(1, "忍者 ");

            //要素の削除
            team.Remove("戦士 ");

            //要素の出力
            foreach (string str in team)
            {
                Console.Write(str);
                /*勇者 忍者 魔法使い*/
            }
        }
    }
}
