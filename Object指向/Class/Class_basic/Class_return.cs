using System;

namespace Class_return
{
    class Class_return

        //Classに変数を引き渡す
    {
        static void Main(string[] args)
        {
            var name = new Person();//new を忘れない
            name.first_name = "太郎 ";//代入する
            name.second_name = "山田";//代入する

            Console.Write(name.Show());
            //名前は太郎 山田です.
        }
    }
    class Person
    {
        public string first_name;
        public string second_name;

        public string Show()
        {      //thisは、おまじない
            return $"名前は{this.first_name}{this.second_name}です.";
            //$は、正規表現
        }
    }

}
