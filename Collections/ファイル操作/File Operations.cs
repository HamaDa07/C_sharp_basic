using System;
using System.IO;
namespace File_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfoオブジェクト　→　ファイル・フォルダを制御する
            //DirectoryInfoオブジェクト → フォルダの制御
            //使い方はFileINfoオブジェクトと同じ

            var file = new FileInfo(@"D:\雑多\ちょっとしたもの\プログラミング関連\date.log");

            //ファイルが存在するか Exists
            Console.WriteLine(file.Exists); //True

            //ファイル名を取得
            Console.WriteLine(file.Name); //date.log

            //フォルダ名を取得
            Console.WriteLine(file.DirectoryName);//D:\雑多\ちょっとしたもの\プログラミング関連

            //読み取り専用か
            Console.WriteLine(file.IsReadOnly);//False

            //ファイルの最終アクセス日時、最終更新日、サイズを取得
            Console.WriteLine(file.LastAccessTime);  //2021/06/08 23:39:58
            Console.WriteLine(file.LastWriteTime);   //2021/06/08 23:39:58
            Console.WriteLine(file.Length);          //6

            //ファイルのコピー  true:上書きOK  false:上書き禁止
            var file2 = file.CopyTo(@"D:\雑多\ちょっとしたもの\プログラミング関連\date2.txt",true);

            //date2:上書き前
            //A\nB  上書き後

            //ファイルを移動+作成
            file2.MoveTo(@"D:\雑多\ちょっとしたもの\プログラミング関連\A\date2.txt");
            //D:\雑多\ちょっとしたもの\プログラミング関連\Aフォルダにdate2.txt

            //ファイル名を変更
            file2.MoveTo(@"D:\雑多\ちょっとしたもの\プログラミング関連\A\date2.txt");


            //ファイルを削除
            file2.Delete();
        }
    }
}
