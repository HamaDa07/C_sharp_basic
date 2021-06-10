using System;

namespace 出力引数
{
    class Output_Arguments
    {
        public void GetMaxMin(int x,int y, out int max, out int min)
        {
            if (x >= y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }
        }

        static void Main(string[] args)
        {
            var method = new Output_Arguments();
            int resultMax, resultMin;

            method.GetMaxMin(5, 3, out resultMax, out resultMin);
            Console.WriteLine("resultMax="+ resultMax);//resultMax=5
            Console.WriteLine("resultMin="+ resultMin);//resultMin=3

        }
    }
}
