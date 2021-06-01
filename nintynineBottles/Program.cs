using System;

namespace nintynineBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Bottles();
        }

        public static void Bottles()
        {
            for (int i = 99; i >= 1; i--)
            {

                Console.WriteLine(" '" + i + "' bottles of water on the wall, '" + i + "' bottles of water.");
                i--; 
                Console.WriteLine(" Take one done and pass it around " + i + "' bottles of water on the wall.");
                i++;
                if (i == 1)

                {
                    Console.WriteLine(" Thanks for playing but I'm out!!!");
                }
            }
        }
    }
}
