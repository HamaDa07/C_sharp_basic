using System;

namespace Pi_sin_cos_tan
{
    class Pi_sin_cos_tan
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);// π(円周率を返す) 3.141592653589793
            Console.WriteLine();

            // sin,cos,tanを表示　　Ceilingは、小数点以下切り上げ

            Console.WriteLine(Math.Ceiling(1234.5));//結果:1235
            Console.WriteLine();

            Console.WriteLine("していした少数の桁で四捨五入");
            Console.WriteLine(Math.Round(1234.35, 1, MidpointRounding.AwayFromZero));//1234.4
            //"5"の部分で四捨五入　Round(小数,四捨五入する桁,MidpointRounding.AwayFromZero))
            //MidpointRouding→数値の丸め処理を行う
            //AwauFromZerp→最も近い値に丸めるモード

            Console.WriteLine();

            Console.WriteLine(Math.Ceiling(Math.Sin(Math.PI / 180 * 30)));//1
            Console.WriteLine(Math.Ceiling(Math.Cos(Math.PI / 180 * 60)));//1
            Console.WriteLine(Math.Ceiling(Math.Tan(Math.PI / 180 * 45)));//1
            Console.WriteLine("上の表記だと正しく表示されない...");
            Console.WriteLine();


            Console.WriteLine(Math.Round(Math.Sin(Math.PI / 180 * 30),1,MidpointRounding.AwayFromZero));//0.5
            Console.WriteLine(Math.Round(Math.Cos(Math.PI / 180 * 60),1,MidpointRounding.AwayFromZero));//0.5
            Console.WriteLine(Math.Round(Math.Tan(Math.PI / 180 * 45),1,MidpointRounding.AwayFromZero));//1



        }
    }
}
