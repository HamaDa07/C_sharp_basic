using System;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            int [] array = new int [1100];
            var max = 0;
            for (var i=0; i < count;  i++)
            {
                array[i]=int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = array[i];
                }

                if (max < array[i])
                {
                    max = array[i];
                }
                   
                
            }
            Console.WriteLine(max);
        }
    }
}
