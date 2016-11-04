using System;

namespace Problem369
{
    class Problem369
    {
        static void Main()
        {
            //input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //logic
            int constResult = 0;
            int result = 0;
            switch (b)
            {
                case 3: constResult = a + c; break;
                case 6: constResult = a * c; break;
                case 9: constResult = a % c; break;
                default: break;
            }
            if (constResult % 3 == 0)
            {
                result = constResult / 3;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(constResult%3);
            }
            Console.WriteLine(constResult);
        }
    }
}
