using System;

namespace Pages
{
    class Pages
    {
        static void Main()
        {
            //input
            int digits = int.Parse(Console.ReadLine());
            int pages = 0;
            
            //logic
            for (int i = 0; digits > 0; i++)
            {
                pages++;
                if(pages < 10)
                {
                    digits -= 1;
                }
                else if (pages < 100)
                {
                    digits -= 2;
                }
                else if (pages < 1000)
                {
                    digits -= 3;
                }
                else if (pages < 10000)
                {
                    digits -= 4;
                }
                else if (pages < 100000)
                {
                    digits -= 5;
                }
                else if (pages < 1000000)
                {
                    digits -= 6;
                }
            }
            Console.WriteLine(pages);
        }
    }
}
