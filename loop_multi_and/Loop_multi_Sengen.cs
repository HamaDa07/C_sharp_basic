using System;

namespace Loop_multi_Sengen
{
    classLoop_multi_Sengen
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 2];
            /*4行 2桁
            **,**,**,**,**/
            
            int[,,] array1 = new int[4, 2, 2];
            /* **,**,**,**
               **,**,**,** */
               
            int[,] array5;
            array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   
            
            array5[2, 1] = 25;//代入

        }
    }
}
