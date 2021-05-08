using System;
using System.Collections.Generic;

namespace Dicitornary_basic1
{
    class Dicitornary_basic1
    {
        static void Main(string[] args)
        {   
          //変数名　= new Dicionary <型名,型名>();
            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "A");
            dictionary.Add(2, "B");
            //     左側;Key,右側;Value    

            var ravel1 = 2;
            var ravel2 = "B";

            Console.WriteLine(dictionary[1]);//A
            Console.WriteLine(dictionary[ravel1]);//B

            /*エラー↓
            Console.WriteLine(dictionary[ravel2]);*/
        }
    }
}
