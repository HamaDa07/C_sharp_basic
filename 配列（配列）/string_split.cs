using System;
using System.Collections.Generic;

namespace string_split2
{
    class string_split
    {
        static void Main()
        {
            
            
                var data = Console.ReadLine();//入力用
                Console.WriteLine(data);

                //文字列を指定の文字で区切るメッソド
                string[] array = data.Split(',');
                //''（シングルコーテーション）じゃないとエラー
                foreach (var str in array)
                {
                    Console.WriteLine(str);
                    int count = str.Split(' ').Length;

                    Console.WriteLine(count);

            }

        }
    }
}
