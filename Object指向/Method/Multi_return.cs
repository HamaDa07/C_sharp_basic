using System;
using System.Collections.Generic;
namespace Multi_return
{
    class Multi_return
    {

        public IEnumerable<string> Getstring()
           //Ienumerable <型名>　メッソド名
        {
            yield return "ABC";
            yield return "DEF";
            yield return "GHI";
        }


        static void Main(string[] args)
        {
            var ite = new Multi_return();

            foreach (var str in ite.Getstring())
            {
                Console.WriteLine(str);
            }
        }
    }
}
