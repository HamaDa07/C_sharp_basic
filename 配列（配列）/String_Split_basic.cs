using System;

namespace Program
{
    class Program
    {

        static void Main(string[] args, int num0)
        {
            string s = "You win some. You lose some.";

            string[] subs = s.Split(' ');//文字列を分解

            foreach (var sub in subs)
            {
                Console.Write($"Substring: {sub}");
                //$"Substring:You
                //$"Substring::win
            }
        }
    }

}
