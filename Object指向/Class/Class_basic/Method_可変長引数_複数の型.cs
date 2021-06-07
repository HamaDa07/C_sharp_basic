using System;

namespace Method_可変長引数_複数の型
{
    class Method_可変長引数_複数の型
    {

        public static void  Normal(params int []list)//listは変数名
        { 
            for (int i=0; i<list.Length; i++ )
            {
                Console.Write(list[i]+" ");
                //1 2 3 4
                
            }
            Console.WriteLine();
        }
        public static void Multi(params object[] list )//paramsの型名を[object]にする
        {
            // int も　string もまとめて引数として引き渡せる
            for(int j=0; j<list.Length;j++)
            {
                Console.Write(list[j] + " ");
                //1 A 1.55
            }
        }

        static void Main(string[] args)
        {
            Normal(1,2,3,4);
            Multi(1, "A", 1.55);
        }
    }
}
