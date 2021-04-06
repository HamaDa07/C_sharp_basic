using System;

namespace Time_basic
{
    class Time_basic
    {
        static void Main(string[] args)
        {   
            //基本
            Console.WriteLine(DateTime.Now);//2021/04/06 21:14:37
            Console.WriteLine(DateTime.Today);//2021/04/06 0:00:00
            Console.WriteLine();
            
            Console.WriteLine(new DateTime(2018, 02, 15, 13, 17, 23));//2018/02/15 13:17:23
            Console.WriteLine();

            //文字列からの変換
            var date1 = "2018/02/15 13:17:23";
            Console.WriteLine(DateTime.Parse(date1));//2018/02/15 13:17:23
            Console.WriteLine();

            //日付などの加算、減算
            var date2 = new DateTime(2018, 02, 15, 13, 17, 23);//　new DateTimeで、日付時刻の情報を与える
            Console.WriteLine(date2);//2018/02/15 13:17:23
            Console.WriteLine();

            Console.WriteLine(date2.AddYears(1));//2019/02/15 13:17:23
            Console.WriteLine(date2.AddMonths(-3));//2017/11/15 13:17:23
            Console.WriteLine(date2.AddDays(30));//2018/03/17 13:17:23
            Console.WriteLine();



        }
    }
}
