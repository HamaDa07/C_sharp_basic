using System;
using System.Collections.Generic;

namespace Example_Multi_Return
{
    class Example_Multi_Return
    {
        //Ienumerable <型名>　メッソド名

        IEnumerable<int> Sosuu(int max)
        {

            //ローカル関数
            bool IsSosuu(int value)
            {
                var sosuu = true;

                // 2 ～ Sqrt (value) で、valueで割り切れる値があるか

                for (var i = 2; i <= Math.Floor(Math.Sqrt(value)); i++){


                    if (value == 0)
                    {
                        sosuu = false;
                        break;
                    }
                }
                return sosuu;
            }


            const int Min = 2;//値が絶対に変わらない

            //引数が2以上じゃないとエラー

            if (max < Min)
            {
                Console.WriteLine("2以上の整数を入力してください");
                yield   break; //yieldエラーは強制的にメッソドを終了させる
            }

            //素数の場合に　yield return 
            for(var num=Min; num<=max; num++ )
            {
                if(IsSosuu(num))
                {
                    yield return num;
                }
            }

        }





        static void Main(string[] args)
        {
            //num1以下の素数を表示させる

            int num1 = int.Parse(Console.ReadLine());
            var a = new Example_Multi_Return();

            foreach (var vale in a.Sosuu(num1))
            {
                Console.WriteLine(vale);
            }

        }
    }
}
