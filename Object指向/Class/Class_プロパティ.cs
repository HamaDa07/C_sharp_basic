using System;

namespace Class_プロパティ
{
    class Class_プロパティ
        //プロバディ プライベートフィールドの読み書き
        //計算をするときに使う機能
{
        static void Main(string[] args)
        {
            var apple = new Item(120, 15);
            var total = apple.GetTotalPrice();
            Console.WriteLine("appleは"+(total));
            var banana = new Item(300, 3);
            Console.WriteLine("bananaは"+banana.GetTotalPrice());
            Console.WriteLine("アイテムは" + Item.Count + "種類です");
            //インスタンス名.プロパティ名」で get{}(引数) を呼び出し、
            //「インスタンス名.プロパティ名 = 値」で set{}(返り値) を呼び出します。
        }
    }

    class Item
    {
        private int price;
        private int quantity;

        public static int Count { get; private set; }//privateは、なくても可
        //set{}の中には主に「メンバ変数 = value」というように記述します。
        //valueは利用者側のクラスで代入された値が格納される予約語です。
        //get{}の中には「return メンバ変数」というように、戻り値を指定する形になります

        public Item(int price,int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            Count += 1;//変数を宣言しなくていい?
        }

        public int GetTotalPrice()
        {
            return price * quantity;
        }

    }
}
