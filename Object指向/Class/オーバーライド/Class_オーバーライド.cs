using System;

namespace Class_オーバーライド
{
    class Class_オーバーライド
    {
        static void Main(string[] args)
        {
            //オーバーライドを利用すると、基底クラスが持つメソッドを、
            //派生クラスで書き換えて再定義することができます。

            var enemy = new Enemy("スライム");
            enemy.Battle();//スライムが現れた

            Console.WriteLine();
            var boss = new Boss("ゾーマ");
            boss.Event();//ゴゴゴゴゴゴゴ
            boss.Battle();//ゾーマが現れた
        }
    }

    class Enemy
    {

        public string Name { get;  set; }

        public  Enemy (string name)//void 等はつけない
        {
            Name = name;
        }

        public virtual void Battle()// (アクセス修飾子) virtual　型名 
        {
            Console.WriteLine(Name+"が現れた");
        }
    }

    class Boss :Enemy//継承
    {
        public  Boss(string name): base (name){

        }

        public void Event()
        {
            Console.WriteLine("ゴゴゴゴゴゴゴ");
        }

        public void Battle()
        {
            Console.WriteLine(Name + "が現れた");
        }


    }

}
