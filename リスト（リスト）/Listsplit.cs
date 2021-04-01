using System;

namespace List_split
{
    class Listsplit
    {
        static void Main(string[] args)
        {
            //複数行のカンマ区切りデータを出力する
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                // ここに、文字列を分割して、出力するコードを書く
                string[] enemy = line.Split(',');//Listを配列して、分割する ''シングルこーてしょん
                Console.WriteLine(enemy[0] + "が" + enemy[1] + "匹現れた");
            }
        }
    }
}
