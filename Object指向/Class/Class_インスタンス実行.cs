using System;

namespace Class_インスタンス実行
{
    class Class_インスタンス実行
    //インスタンス:クラスをnewしたもの
    //このような普通なやり方だと、任意の戻り値が期待できない
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class2(); 
            Console.WriteLine(c1.Print1());
            //クラス1-print1

            //↓エラー 子クラスから親クラスへの代入は不可
           // Class2 c2 = new Class1();
           // Console.WriteLine(c2.Print2());
        }
    }

    class Class1
    {
        public string Print1()
        {
            return "クラス1-print1";
        }
    }

    class Class2 :Class1
    {
        public string Print2()
        {
            return "クラス2-print2";
        }
    }
}
