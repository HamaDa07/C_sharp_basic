using System;

namespace Hairetu_sort_serch
{
    class Hairetu_sort_serch
    {
        static void Main(string[] args)
        {
            var str1 = new[] { "giants", "carp", "dragons", "tigers", "baystars", "swallows" };

            //sort データを一定の基準に従って並べかえること。
            Array.Sort(str1);//(今回は、ABC順)
            Console.WriteLine(string.Join("& ",str1));//baystars& carp& dragons& giants& swallows& tiger

            //配列のN番目から要素を検索 
            Console.WriteLine(Array.BinarySearch(str1,"giants"));//3
            Console.WriteLine(Array.BinarySearch(str1, "dragons"));//2

            /*Console.WriteLine(Array.BinarySearch(str1, "dragon"));
            *要素がない場合は,適当な値が返される//-4*/

            var array2 = new []{ "A", "B", "C", "D", "E" };
            var array3 = new string[5];
            Array.Copy(array2, 1, array3, 1, 3);
            // array2 の1~3(B~D) を"空"の配列 array3にコピー
            Console.WriteLine(string.Join("& ", array3));//& B& C& D&
            //　すでに要素がある配列にコピーはできない


            

        }
    }
}
