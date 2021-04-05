using System;

namespace Continue_basic
{
    class Continue_basic
    {
        static void Main()
        {
            int ans = 0;

            for(int i =0; i<100; i++)
            {
                if (i % 2 != 0)
                {
                    continue;//スキップする
                }

                ans += i;
            }

            Console.WriteLine("合計は"+(ans)+"です");
        }
    }
}
