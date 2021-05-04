using System;

namespace Loop_multi_scan
{
    class Loop_multi_scan
    {
        static void Main(string[] args)
        {   
            //要素を代入

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int[][] numberB = new int[a][];

            //2番めの[]の要素を代入する
            for(int i=0; i<numberB.Length; i++)
            {
                numberB[i] = new int [b];
            }

            for(int i=0; i < numberB.Length; i++)//2
            { 
                for(int j=0; j<numberB[i].Length; j++)//5
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
