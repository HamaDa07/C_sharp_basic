using System;

namespace Class_static
{
    class Class_static
    {
        //staticを理解する
        //static からのアクセス:　クラス名.関数名で呼び出せる

        static void Main(string[] args)
        {
            var apple = new Item(120, 15);
            var total = apple.GetTotalPrice();
            Console.WriteLine("合計金額は"+total+"円です");

            var orange = new Item(85, 32);
            Console.WriteLine("合計金額は" + orange.GetTotalPrice() + "円です");
            Console.WriteLine("アイテムは" + Item.GetCount() + "種類です");
            //static からのアクセス:　クラス名.関数名で呼び出せる
        }
    }
    public class Item
    {
        private int price;
        private int quantity;
        private static int count = 0;//staticのメッソドを使って、値を引き渡せる

        public Item(int price,int quantity)
        {
            this.price = price;
            this.quantity = quantity;
            count += 1;
        }
        public int GetTotalPrice()
        {
            return price * quantity;
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
