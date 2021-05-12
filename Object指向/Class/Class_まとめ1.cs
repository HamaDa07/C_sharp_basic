using System;

namespace Class_まとめ1
{
    class Class_まとめ1
    {/*内容:
      クラスの宣下、Main関数からクラスへの引数を渡す,コンストラクタ,{get; set;},クラスの継承*/
        static void Main(string[] args)
        {
            var person = new Person("ジョン先生",30);//strig と intの引数をそれぞれ渡す
            person.Show();//Person(親クラス:) ジョン先生30 才です

            var student = new Student("マック", 15,"Id4312");
            student.Show();//Student(子クラス);マック 15才, 学生番号:Id4312

        }
    }

    class Person
    {
        private string name; //変数の宣言
        private int age;
        public int Age { get; set; } //set... Age = age;


        public Person(string name ,int age)//
        {//コンストラクタの初期化
            this.name = name; //this.変数名=変数名
            Age = age;//Ageメッソドに変数ageを代入する
        }

        public string Name
        {
            set { this.name = value; }//引数の受け取り
            get { return this.name; }//返り値
        }

        public void Show()
        { 
            Console.WriteLine("Person(親クラス:) "+Name+Age+" 才です.");
        }

    }

    class Student : Person  //Personクラスを継承 
    {
        private string id;
        public Student(string name, int age, string id) : base( name,  age)//base部分の型名はいらない;
        {
            this.id = id;//set getを使うため、thisを使う
        }
        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }
        public void Show()
        {
            Console.WriteLine("Student(子クラス);" + Name+" "+ + Age+"才, 学生番号:" + Id);
            // 親クラスのメッソドを参照できる
        }
    }
}

