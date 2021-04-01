using System;

namespace Null_moji
{
    class Null_moji
    {
        static void Main(string[] args)
        {
            var moji = "";

            //nullは、何も入っていないという意味

            if ((moji = Console.ReadLine()) != null)
            {
                Console.WriteLine("文字が入力されたね！");

            }
            else
            {
                Console.WriteLine("残念入力なし");
            }
        }
    }
}
