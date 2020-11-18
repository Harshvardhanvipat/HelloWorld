using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winNum = r.Next(0, 10);
            bool win = false;
            do
            {
                Console.Write("Guess a number between 0 and 100");
                string s = Console.ReadLine();
                // this line will error if user inputs something else then a number
                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high, guess lower !!!");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low, guess higher !!!");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("You Win");
                    win = true;
                }
                Console.WriteLine();
            }
            while (win == false);
            Console.WriteLine("Thank you playing the game !!");
            Console.WriteLine("Press any key to finish!!");
            Console.ReadKey(true);




        }
    }
}
