using System;
using System.Collections.Generic;
namespace List_basic
{
    class List_basic
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 10, 15, 30, 60 };
            var list2 = new List<int> { 1, 5, 3, 6 };
            // 変数名 = new List　<型名>　{要素0,要素1...};

            list.Insert(2, 7);//2番目の要素に7を追加
            list.Add(120);//一番最後の要素に120を追加
            
            foreach(var v in list)
            {
                Console.Write(v);
                //10  15  7  30  60  120
            }
            Console.WriteLine();
            //list={10  15  7  30  60  120};
            Console.WriteLine(list.Count);//要素数:6
            Console.WriteLine(list[0]);//0番目の要素:10
            Console.WriteLine(list.Contains(30));//リストの中の要素の有無:True
            Console.WriteLine(list.IndexOf(30));//0番目の要素から 30 の位置を表示:3
            Console.WriteLine(list.IndexOf(10, 2, 2));//2番目の要素から2つ要素を検索:-1
            //↑一番近い位置の場所を指す
            Console.WriteLine(list.IndexOf(0));//要素が見つからないときは,-1を表示:-1
          
        }
    }
}
