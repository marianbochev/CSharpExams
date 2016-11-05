using System;

namespace Busses
{
    class Busses
    {
        static void Main()
        {
            //input
            int numberOfBusses = int.Parse(Console.ReadLine());
            int maxSpeed = 1500;
            int groups = 0;
            
            //logic
            for (int i = 1; i <= numberOfBusses; i++)
            {
                int bus = int.Parse(Console.ReadLine());
                if(bus <= maxSpeed)
                {
                    int groupspeed = bus;
                    maxSpeed = groupspeed;
                    groups++;
                    
                }
            }
            Console.WriteLine(groups);
        }
    }
}
