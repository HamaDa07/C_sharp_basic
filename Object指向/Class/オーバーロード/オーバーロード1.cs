using System;

namespace Class_オーバーロード
{
    class Class_オーバーロード
    {
        //オーバーロード...同じ名前でパラメータの数や
        //型が異なるメソッドが複数宣言されている状態

        //関数を再利用できる(スコープは通常道理)

        public static void Main()
        {
            string enemy = "スライム"; //スライムが現れた
            Battle(enemy);              //勇者の攻撃
            Battle("攻撃", "勇者"); //スライムに100ダメージ
            Battle(100,enemy);
        }

        static string  Battle(string enemy)
        {
            Console.WriteLine(enemy + "が現れた");
            return enemy;
        }
        static void Battle(string skill, string player)
        {
            Console.WriteLine(player + "の" + skill);
        }

        static void Battle(int damage,string enemy)//いちど使った変数を再定義
        {
            Console.WriteLine(enemy + "に" + damage + "ダメージ");
        }
    }
    
}

