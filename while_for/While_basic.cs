using System;

namespace While_basic
{
    class While_basic
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i < 5)
            {
                Console.WriteLine("hello");
                i += 1;

            }
            Console.WriteLine("last " + i);
        }
    }
}
