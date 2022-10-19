using System;
namespace Uppgift_4_22
{
    class Program
    {
        static void Main(string[]args)
        {
            for(int i = 10; i <= 30; i++)
            {
                Console.WriteLine(i);
            }
            for (int j = 200; j >= 180; j--)
            {
                Console.WriteLine(j);

            }

            for (int m = 1000; m <= 1400; m = m + 50)
            {
                Console.WriteLine(m);
            }

        }
    }
}

