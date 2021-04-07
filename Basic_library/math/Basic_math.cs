using System;

namespace Math_basic
{
    class Basic_math
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-100));//絶対値を求める　結果:100

            Console.WriteLine(Math.Sign(-100));//符号を求める 結果:-1
            //正の数:1 0:0 負の数:-1

            Console.WriteLine(Math.Max(3, 2));//最大値を求める
            Console.WriteLine("MAX={0}", Math.Max(5, Math.Max(3, 2)));//MAX=5
            Console.WriteLine("Min={0}", Math.Min(0, Math.Min(1, 2)));//Min=0
            Console.WriteLine();

            Console.WriteLine(Math.Ceiling(1234.91));//切り上げ 1234.9→1235
            Console.WriteLine(Math.Floor(1234.91));//切り下げ 1234.9→1234
            Console.WriteLine();

            //切り上げ（小数点）
            //小数第一を0とする (数字,小数のけた)
            Console.WriteLine(Math.Round(1.15, 1)); //1.2
            Console.WriteLine(Math.Round(1.15, 0)); //1
            Console.WriteLine();

            Console.WriteLine(Math.Sqrt(2));//平方根 結果:1.4142135623730951
            Console.WriteLine();

            int num1 = 4;
            double num2 = 0.5;
            double num3 = 1 / 2;


            Console.WriteLine(Math.Pow(num1, num2));// 4の 0.5乗　結果:2
            Console.WriteLine(Math.Pow(num1, num3));// 4の 1/2乗  結果:1
            Console.WriteLine();
            //二つ目の因数を分数として代入すると、正しい値が返ってこないため少数で表す


            //Logの計算
            Console.WriteLine(Math.Exp(3));//e(自然対数の底)の3乗
            Console.WriteLine(Math.Log(8,2));//Log2 8=3
            Console.WriteLine(Math.Log10(100));//2 底が10の時だけの特別な形
            
            /*これはエラー(Math.Log5(125));*/




        }
    }
}
