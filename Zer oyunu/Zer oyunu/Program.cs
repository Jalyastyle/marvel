using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice1; int dice2;
            Random random = new Random();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please, toss the dice.");
            dice1 = random.Next(1, 7);
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Please, press any key to roll your dice.");
            Console.WriteLine();
            dice2 = random.Next(1, 7);
            Console.ReadKey();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            while (count1<3 && count2<3 && count3<3)
            {
                if (dice1 == dice2)
                {
                    Console.WriteLine("Roll again.");
                    count1++;
                }
                else if (dice1 > dice2)
                {
                    Console.WriteLine("Player 1 won");
                    count2++;
                }
                else
                {
                    Console.WriteLine("Player 2 won");
                    count3++;
                }
                if (count1==3)
                {
                    Console.WriteLine("The game is tied.");
                }
                else if (count2 == 3)
                {
                    Console.WriteLine("Player1 is the winner.");

                }
                else
                    Console.WriteLine("Player2 is the winner.");
            }
            
        }
    }
}

