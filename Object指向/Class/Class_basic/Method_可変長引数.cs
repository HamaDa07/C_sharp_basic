using System;

namespace Method_可変長引数
{
    class Method_可変長引数
    {
        // 可変長引数(任意の数の引数を関数に渡す方法) 
        static void Main(string[] args)
        {
            Hello("安達了一 ");//Hello 安達了一 さん
            Console.WriteLine();
            Hello("安達了一 ", "イルカ ", "ウカムルバス ");
            /*Hello 安達了一 さん
              Hello イルカ さん
              Hello ウカムルバス さん*/
        }
        static void Hello(params string [] people)
        //params string[] 変数名
        {   
            //foreachを忘れないこと!!
            foreach (string name in people)
            {
                Console.WriteLine("Hello " + name + "さん");
            }
        } 
    }
}
