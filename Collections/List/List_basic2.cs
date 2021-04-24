using System;
using System.Collections.Generic;

namespace List_basic2
{
    class List_basic2
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            var list2 = new List<int> { 1, 5, 3, 6 };
            var list3 = new List<int> { 10, 15, 30, 60 };

            // 変数名 = new List　<型名>　{要素0,要素1...};

            Console.WriteLine(list3.Remove(60));//True
            Console.WriteLine(list2.Remove(60));//False
            foreach (var i in list3)
            {
                Console.WriteLine(i);//10,15,30
            }
            Console.WriteLine();

            list.AddRange(list2);//listにlist２を結合　{list,list2}
            foreach(var j in list)
            {
                Console.Write(j);//10,15,30,60,1,5,3,6
            }
            Console.WriteLine();

            list.Reverse();//listの要素を反転　
            // 元:{1,2,3}   後:{3,2,1}
            foreach(var k in list)
            {
                Console.Write(k);//6,3,5,1,60,30,15,10
            }
            Console.WriteLine();

            var array = new int[3];
            Console.WriteLine(array);
            list.CopyTo(2, array, 0, 3);
            //リスト{6,3,5,1,60,30,15,10} 
            //CopyTo(リスト側の開始位置,要素,配列側の開始位置,コピーする要素数)
            Console.WriteLine(String.Join(",", array));//5,1,60
            var array2 = new int[4];
            list.CopyTo(3, array2, 1, 3);
            Console.WriteLine(String.Join(",",array2));//0,1,60,30
            //この場合は、0番目の要素に何も代入されていないため
            //自動的に0が代入される(int型の場合)
        }
    }
}
