using System;

namespace 値渡し
{
    class 値渡し
    {
        public int CountUP(int count)
        {
            count++; //count+=1と同じ結果になる
            return count;////Method CountUP=2
        }

        public int CountUP2(ref int count)// ref 型名　変数名　ポインタみたいな感じにできる
        {
            count += 3; //count++　を三回分と同じ
            return count;//Method CountUP2=4
        }

     
        public int [] Update(int [] date)
        {//元の配列　2, 4, 6

            date[0] = 5;////Method Update=5
            date[1] = -10;////Method Update=-10
            return date;
        }

        public int [] Update2(int [] date)
        { //元の配列  2, 4, 6
            date = new[] { 1, 2, 3 }; //配列のコピー
            return date;
            // 元の配列        date2 [0] = 10
            ////Method Update2 date2 [0] = 1
            //Method実行後     date2 [0] = 10
        }


        static void Main(string[] args)
        {
            var count = 1;
            var countup=new 値渡し();//変数をコピーする感じ
            Console.WriteLine($"Method CountUP={countup.CountUP(count)}"); //Method CountUP=2
            Console.WriteLine($"Main関数のcount={count}");    //var count=1
            Console.WriteLine();

            Console.WriteLine($"Method CountUP2={countup.CountUP2(ref count)}");//ref 変数を忘れずに
            Console.WriteLine();//Method CountUP2=4

            int i =0;
            var date = new int[] { 2, 4, 6 };
            var update = new 値渡し();//ポインタみたいな感じ(書き換え)
            Console.WriteLine("元の配列[0]"+date[0]);  //元の配列2
            Console.WriteLine("元の配列[1]" + date[1]); //元の配列4
            Console.WriteLine();

            //変数名.関数名(配列名)[i]
            Console.WriteLine($"Method Update={update.Update(date)[i]}");//Method Update=5
            i++;
            Console.WriteLine($"Method Update={update.Update(date)[i]}");//Method Update=-10
            Console.WriteLine($"Main関数のdate[0]={date[0]}");//Main関数のdate[0]=5
            Console.WriteLine($"Main関数のdate[0]={date[1]}");//Main関数のdate[0]=-10
            Console.WriteLine();

            var date2 = new[] { 10, 20, 30 };
            var update2 = new 値渡し(); //Method内で、 new を使って配列を再定義したので、
            //変数をコピーするのと同じ

            Console.WriteLine($"元の配列 date2[0]={date2[0]}");//元の配列 date2[0]=10
            Console.WriteLine($"Method Update2={update2.Update2(date)[0]}");//Method Update2=1
            Console.WriteLine($"Main関数の配列date2={date2[0]}");//date2=10
            Console.WriteLine();


        }
    }
}
