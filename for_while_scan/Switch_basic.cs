using System;

namespace Switch_basic
{
    class Switch_basic
    {
        static void Main(string[] args)
        {
            var number = "";
            Console.WriteLine("数字を入力してください");
            number = Console.ReadLine();

            switch(number)//switch(変数))
            {
                case "1": //case 値:
                    Console.WriteLine("1です");
                    break;

                case "2":
                    Console.WriteLine("2です");
                    break;

                default:
                    Console.WriteLine("1,2以外の数字です");
                    break;
            
            }



           
        }
    }
}
