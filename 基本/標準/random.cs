// 数の表示とサイコロ
using System;

namespace Randomnumber
{
    public class Program
    {
        public static void Main()
        {
            var random = new Random();
            /*ランダムクラスをインスタンス化
            インスタンスは、クラスを利用すること
             newは、作るという意味*/

            var number = random.Next(1, 101);
            /*random.Next()は、0以上の数字を表示
            Next(1,101)1から100まで(101未満)のランダムな数字*/
            Console.WriteLine(number);
        }
    }
}