using System;

namespace LoopLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string username = Console.ReadLine();
            Console.WriteLine("Please input an integer between 1 and 100:");
            int num1 = int.Parse(Console.ReadLine());

            if ((num1 < 0) || (num1 > 100))
            {
                Console.WriteLine("The Rock says, 'Please select a number from 1 and 100, jabroni!'");
            }
            else
            {
                if (num1 % 2 == 1)
                {
                    Console.WriteLine($"{username}: {num1} is odd!");
                }
                else if ((num1 % 2 == 0) && (num1 > 2) && (num1 < 25))
                {
                    Console.WriteLine($"{username}: {num1} is even and less than 25.");
                }
                else if ((num1 % 2 == 0) && (num1 > 25) && (num1 < 60))
                {
                    Console.WriteLine($"{username}: {num1} is even (between 25 and 60).");
                }
                else if ((num1 % 2 == 0) && (num1 > 60))
                {
                    Console.WriteLine($"{username}: {num1} is even (greater than 60).");
                }
                else if ((num1 % 2 == 1) && (num1 > 60))
                {
                    Console.WriteLine($"{username}: {num1} is odd (greater than 60).");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }
}
