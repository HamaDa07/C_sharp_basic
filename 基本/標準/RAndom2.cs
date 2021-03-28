using System;

namespace Randomnumber2
{// 値段計算をしてみよう 
    public class Random2
    {
        public static void Main()
        {
            var random = new Random();
            var apple_price = random.Next(1, 4) * 100;//ランダムなリンゴの単価
            var apple_num = random.Next(10) + 1;//ランダムな個数

            Console.WriteLine("リンゴの単価" + apple_price + "円");
            Console.WriteLine("リンゴを買う数" + apple_num + "個");

            var total = apple_price * apple_num;
            Console.WriteLine("合計金額 " + total + " 円");
        }
    }
}