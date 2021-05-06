using System;

namespace Class_コンストラクター
{
    class Class_コンストラクター
    {
        //コンストラクターとは,名前がその型の名前と同じメソッド
        //クラス(Add)のメッソド(Add)
        static void Main(string[] args)
        {
            var player1 = new Player("ジョン");//var変数がおすすめ
            player1.Walk();//ジョンです。

            var player2 = new Player("太郎");//var変数がおすすめ
            player2.Walk();//太郎です。
            player1.Walk();//ジョンです。
        }
    }

    class Player
    {
        private string name;
        
        public Player(string name)
        {
            this.name = name;//コンストラクター...クラス名とメッソド名が同じメッソド
            //コンストラクターで、変数を使うときにthisを使う
        }
        public void Walk()
        {
            Console.WriteLine(name + "です。");
        }

    }
}
