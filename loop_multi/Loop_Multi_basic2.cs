using System;

namespace Loop_Multi_basic2
{
    class Loop_Multi_basic2
    {
        static void Main(string[] args)
        {
            string[][] teams ={              // string[][] 変数名 {
        new string[] {"A0","A1"}, //new string[] {"要素","要素"},
        new string[] {"B0","B1","B2"}, //new string[] {"要素"}
        new string[] {"C0","C1","C2"}, //};
        new string[] {"D0"}
        };
            //new stringは、固定 //要素を加えるときに=(イコール)はいらない

            Console.Write("[0][0]に入っているもの"+teams[0][0]);
            //更新(再代入する)とき
            teams[0][0] = "更新済み";

            //配列の長さ 
            Console.WriteLine("配列の個数（縦）"+teams.Length);//結果:4
            Console.WriteLine("一つの配列の要素(横)" + +teams[0].Length);//結果2
        }
    }
}
