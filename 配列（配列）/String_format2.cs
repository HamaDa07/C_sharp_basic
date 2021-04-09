using System;

namespace String_format2
{
    class String_format2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(string.Format("名前は{0,5}です","ジョン"));
            //名前は ジョンです 一番最後の文字が5になる


            Console.WriteLine(string.Format("名前は{0,-5}です", "ジョン"));
            //名前はジョン  です

            Console.WriteLine(string.Format("名前は{0,-5}です", "K.ジョンソン"));
            //名前はK.ジョンソンです
            //入力したい文字のほうが文字数が多い場合は、空白は無効になる



        }
    }
}
