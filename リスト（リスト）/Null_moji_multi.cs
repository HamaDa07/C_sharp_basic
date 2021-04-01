using System;

namespace Null_moji_multi
{
    class Null_moji_multi
    {
        static void Main(string[] args)
        {
            //複数データを読み込む

            var team = new List<string>();//入力　＋　リストの宣言

            string line;

            // 行まで読み込む
            while ((line = Console.ReadLine()) != null)
            {
                team.Add("hello " + line);
            }

            foreach (var str in team)
            {
                Console.WriteLine(str);//出力
            }
        }
    }
}
