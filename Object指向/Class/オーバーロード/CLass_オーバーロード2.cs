using System;

namespace Class_オーバーロード2
{
    class CLass_オーバーロード2
    {
        static void Main(string[] args)
        {
            // ${this.変数} が戻り値のとき
            Battle battle1 = new Battle();//クラス 変数 = new メッソド
            string result1=battle1.Encount1();
            Console.WriteLine(result1);//スライムが現れた

            Battle battle2 = new Battle("さまようよろい");
            battle2.Encount2();
        }
    }
    class Battle
    {
        string enemy;
        public Battle()
        {
            enemy = "スライム";
        }

        public Battle(string a)//コンストラクタも使える,引数を代入する
        {
            this.enemy = a;//何も代入されなかったときは
        }                       //初期値(スライム)が返される
        public string  Encount1()
        {
            return ($"{this.enemy}が現れた");
        }

        public void Encount2()
        {
            Console.WriteLine(this.enemy + "が現れた");
        }
    }

}
