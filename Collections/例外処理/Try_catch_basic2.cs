using System;

namespace Try_catch_basic2
{
    class Try_catch_basic2
    {
        static void Main(string[] args)
        {
            var array = new[] { "A", "B", "C" };
            try
            {
                var i = 0;

                //無限ループ
                while (true)
                {
                    Console.WriteLine(array[i++]);
                }
            }

            //参照する要素がなくなるを処理する
            catch (IndexOutOfRangeException )
            {

            }
        }
    }
}
