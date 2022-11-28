using System;

namespace pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg=0;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter number "+(i+1)+" :");
                avg += Convert.ToDouble(Console.ReadLine());
            }

            Console.ForegroundColor = (ConsoleColor)2;
            Console.WriteLine("AVG ===> " + (avg /= 4)); 
        }
    }
}
