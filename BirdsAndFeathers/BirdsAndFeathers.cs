using System;

namespace BirdsAndFeathers
{
    class BirdsAndFeathers
    {
        static void Main()
        {
            //input
            ulong birds = ulong.Parse(Console.ReadLine());
            ulong feathers = ulong.Parse(Console.ReadLine());
            ulong evenBirds = 1;
            ulong oddBirds = 1;
            ulong result = 1;
            //logic
            double averageSum = (double)feathers / birds;
            if (birds % 2 == 0)
            {
                averageSum = (double)averageSum * 123123123123;
                Console.WriteLine("{0:F4}", averageSum);
            }
            else
            {
                averageSum = (double)averageSum / 317;
                Console.WriteLine("{0:F4}", averageSum);
            }

        }
    }
}
