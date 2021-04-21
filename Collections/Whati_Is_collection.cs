using System;
using System.Collections.Generic;
namespace Whati_Is_collection
{
    class Whati_Is_collection
    {
        static void Main(string[] args)
        {
            /*コレクション...オブジェクトを集合を表すためのクラス
              using System.Collections.Generic;を使う
              
            リスト...順序を持つ、要素は重複してもいい
            セット...要素に順序はない、要素の重複はNG
            マップ...キー/値の組で管理,キーの重複はNG

             */

            /*イメージ
            リスト ... A B C D ...Z
            セット ... B D Z G
            マップ ... 1-A 2-B 3-C 
             */

            Console.WriteLine("問題　選択肢:マップ,リスト,セット");
            Console.WriteLine("1.キー/値の組で管理,キーの重複はNG");
            Console.WriteLine("2.要素に順序はない、要素の重複はNG");
            Console.WriteLine("3.順序を持つ、要素は重複OK");

            Console.WriteLine("answer is ...");

            string[] answer = new string[10];
            for (var i = 0; i < 3; i++)
            {
                answer[i] = Console.ReadLine();
            }
            string[] str = { "マップ", "セット", "リスト" };
            for(var j=0; j < 3; j++)
            {
                if (answer[j] == str[j])
                {
                    Console.WriteLine("正解:"+(str[j]));
                }
                else
                {
                    Console.WriteLine("不正解 あなたの回答: " + answer[j] + " 正解は," + (str[j]));
                }
            }

        }
    }
}
