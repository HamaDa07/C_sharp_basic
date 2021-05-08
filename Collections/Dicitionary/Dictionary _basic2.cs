using System;
using System.Collections.Generic;
namespace Dictionary_basic2
{
    class Dictionary_basic2
    {
        static void Main(string[] args)
        {
            var dicionary = new Dictionary<int,string>();

            dicionary.Add(1, "One");
            dicionary.Add(2,"Two");
            dicionary.Add(3, "Three");
            Console.WriteLine(dicionary[1]);
            Console.WriteLine(dicionary[2]);
            Console.WriteLine(dicionary[3]);

            Console.WriteLine();
            //要素数の確認    Count=3
            Console.WriteLine("Count:"+dicionary.Count);

            //Valueの置き換え
            // 変数名[Key]= Value
            dicionary[1] = "Change_One";
            Console.WriteLine(dicionary[1]);

            //要素のRemove
            // 変数名.Remove(key)
            dicionary.Remove(1);
                




        }
    }
}
