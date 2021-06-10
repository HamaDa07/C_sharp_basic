using System;

namespace Simple_Output_Arguments
{
    class Simple_Output_Arguments
    {
        public (int max, int min) GetMaxMin(int x, int y)
        {
            return x >= y ? (x, y) : (y, x);
            //return x>=y ? (max: x,min: y) : (max: y,min: x);
        }


        static void Main(string[] args)
        {

            var a = new Simple_Output_Arguments();
            var method = a.GetMaxMin(5,3);

            //method.メッソドで定義した変数
            Console.WriteLine("Max=" + method.max);//Max=5
            Console.WriteLine("Min=" + method.min);//Min=3

            //書き換えることもできる  max→max1   min→min1
            var (max1, min1) = a.GetMaxMin(-1, 3);
            Console.WriteLine("max1=" + max1);
            Console.WriteLine("min1=" + min1);

        }
    }
}
