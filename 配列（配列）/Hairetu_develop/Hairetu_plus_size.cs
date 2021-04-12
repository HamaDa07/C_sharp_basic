using System;

namespace Hairetu_plus_size
{
    class Hairetu_plus_size
    {
        static void Main(string[] args)
        {
            var str1 = new[] { "giants", "carp", "dragons", "tigers", "baystars", "swallows" };
            var array2 = new[] { "A", "B", "C", "D", "E" };
            var array3 = new string[5];

            Array.Resize(ref array2, array2.Length + 3);
            //ref str1 指定された配列(str1)をメッソドの中で、そのまま操作しなさいという意味
            // 配列str1 に空要素　を　3つ増やす
            Console.WriteLine(string.Join("& ",array2));
            //A& B& C& D& E& & &

            //配列 array2の2～3番目を空にする
            Array.Clear(array2, 1, 2);
            Console.WriteLine(string.Join("& ", array2));
            //A& & & D& E& & &



        }
    }
}
