using System;

namespace Hairetu_scan
{
    class Hairetu_scan
    {
        static void Main(string[] args)
        {
            //配列の宣言と入力

            int[] a = new int[5];
            // 配列型変数 = new 型名[配列の長さ];

            int[] b = { 1, 2, 3 };
            //こんなのも可能


            int [] cat = new int [5];
            for (var abc= 0; abc < 5; abc++)
            {
                cat[abc] = int.Parse(Console.ReadLine());
            }
            
            //配列から配列への代入

            string[] str1 = new string[5];
            var j = 0;

            foreach (var i in str1)
            {
                j++;
                var str2 = str1[j];
            }
        }
    }
}
