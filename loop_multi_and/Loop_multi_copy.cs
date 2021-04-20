using System;

namespace Loop_multi_copy
{
    class Loop_multi_copy
    {
        static void Main(string[] args)
        {
            var multi = new string[,] { {"あ","い","う","え","お" }, {"A","B","C","D","E" } };
            var multi2 = new string[2, 3];

            //(3~6番目をコピー)
            /////////////////////////////
            /// 挙動確認////////////
            /// ////////////////
            Array.Copy(multi, 2, multi2, 0, 6);
            foreach (var v in multi2)
                Console.Write(v);
            //うえおABC
        }
    }
}
