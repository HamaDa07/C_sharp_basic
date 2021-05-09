using System;

namespace Class_初期化
{
    class Class_初期化
    {
        static void Main(string[] args)
        {
            var show = new Person("コンストラクター"){ value = "オブジェクト初期化" };

            Console.WriteLine(show.value);
            //オブジェクト初期化

            //優先順位
            //1.オブジェクト初期化子{変数名=}
            //2.コンストラクター   new クラス名 ()
            //3.フィールド  public static ～～
        }
    }
    class Person
    {
        public string value = "フィールド";

        public Person() { }

        public Person(string value)
        {
            this.value = value;
        }
    }

}



