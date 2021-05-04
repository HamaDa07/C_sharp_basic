using System;

namespace Loop_multi_New
{
    class Loop_multi_New
    {
        static void Main(string[] args)
        {
            int[] numberA = new int[10];

            //型名[] 変数名 = new 型名 [要素数];
            Console.WriteLine("numberA.Length" + numberA.Length);
            //要素の数をカウント　結果:10

            int[][] numberB = new int[2][];
            //型名[][] 変数名  = new 型名[数][]
            Console.WriteLine("numberB.Length" + numberB.Length);
            //結果:2
            for(int i=0; i<numberB.Length; i++)
            {
                numberB[i] = new int [5];
            }
            //0 
            Console.WriteLine("numberB.Length" + numberB.Length);

            for(int i=0; i < numberB.Length; i++)//2回
            {
                for(int j=0; j<numberB[i].Length; j++)//5回
                {
                    numberB[i][j] = i + j;
                    Console.Write(numberB[i][j] + " ");
                   /* 0 1 2 3 4
                      1 2 3 4 5 */
                }
                Console.WriteLine();
            }
           
        }
    }
}
