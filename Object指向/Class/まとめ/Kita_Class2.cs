using System;

namespace Kita_Class2
{
    class Kita_Class2
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            var coin = new CoinCase();
            coin.Getmoney(first);
            //coin.Getmoney();←これだと計算される前の値が返される
            coin.Five_hun();
            coin.One_hun();
            coin.Fifty();
            coin.Ten();
            coin.One();
            coin.Getmoney();
            /*コインの数: 500￥444 100￥:2 50￥0 10￥2 one￥2
                コインの総数:450*/
        }
    }

    class CoinCase
    {
        public int getmoney;

        public int five_hun;
        public int one_hun;
        public int fifty;
        public int ten;
        public int one;
        public int Count { get; set; }
        public void Getmoney( int getmoney)
        {
            this.getmoney = getmoney; 
        }
       
        public void  Five_hun()
        {
            five_hun = getmoney / 500;
            getmoney -= five_hun * 500;
            Count += five_hun;
            //Console.WriteLine(five_hun + " " + getmoney + " " + Count);
        }

        public void One_hun()
        {
            one_hun = getmoney / 100;
            getmoney -= one_hun * 100;
            Count += one_hun;
            //Console.WriteLine(one_hun + " " + getmoney + " " + Count);

        }
        public void Fifty()
        {
            fifty = getmoney / 50;
            getmoney -= fifty * 50;
            Count += fifty;
            //Console.WriteLine(fifty + " " + getmoney + " " + Count);

        }
        public void Ten()
        {
            ten = getmoney / 10;
            getmoney -= ten * 10;
            Count += ten;
            //Console.WriteLine(ten + " " + getmoney + " " + Count);

        }
        public void One()
        {
            one = getmoney / 1;
            getmoney -= one * 1;
            Count += one;
            //Console.WriteLine(one + " " + getmoney + " " + Count);

        }
        public void Getmoney()
        {
            Console.WriteLine($"コインの数: 500￥{five_hun}枚 100￥:{one_hun}枚 50￥{fifty}枚 10￥{ten}枚 one￥{one}枚");
            Console.WriteLine($"コインの総数:{Count}");
        }
    }
}
