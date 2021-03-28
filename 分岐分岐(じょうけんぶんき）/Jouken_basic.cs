using System;

namespace if_basic2
{
    class jouken_basic2
    {
        public static void Main()
        {
            var time = 12;
            if (time < 12)
            {
                Console.WriteLine("午前");    // 条件式が成立したときの処理
            }
            else if (time == 12)
            {
                Console.WriteLine("正午");
            }
            else
            {
                Console.WriteLine("午後");
            }
        }
    }
}
