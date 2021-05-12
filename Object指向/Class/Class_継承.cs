using System;

namespace Class_継承
{
    class Class_継承
    {
        static void Main(string[] args)
        {
            var box = new Box("Box");
            box.Open();//これはBoxメッソドから

            var golden = new Golden_Box("金色");
            golden.Open();//これは金色メッソドから
            golden.Fake();//金色は、偽物です
        }
    }

    class Box
    { 
        public string Item { get; set; }//戻り値 Box

        public Box(string item)//"Box"を受け取る
        {
            Item = item;// Itemメッソドに"Box"を代入する
        }

        public void Open()
        {
            Console.WriteLine("これは" + Item + "メッソドから");
            //変数の代わりにメッソド名
        }
    }
    //クラスの継承
     class Golden_Box:Box // 派生クラス名 : 基底クラス名
    { 
        public  Golden_Box(string item ):base(item)//初期化みたいなもん
           // 派生クラスのコンストラクタ(引数) : base(基底クラスに渡したい引数)
        { 
        }

        public void Fake()
        {
            Console.WriteLine(Item +"は、偽物です");
        }
    }

}
