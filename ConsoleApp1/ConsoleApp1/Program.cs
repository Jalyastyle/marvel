using System;

namespace ConsoleApp1
{
    class Program
    {
        private static int pin;

        static void Main(string[] args)
        {
            int a = 1000;

            Console.WriteLine("Enter the pin:");
            Console.WriteLine("--------------");
            int pin = Convert.ToInt32(Console.ReadLine());




            if (pin == 1441)
            {
                Console.WriteLine("Choose the operation:");
                Console.WriteLine("1.To check balance");
                Console.WriteLine("2.To withdraw money");
                Console.WriteLine("3.To deposite Money");
                Console.WriteLine("4.To change the pin");
                Console.WriteLine("Enter your choice");


                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:

                        break;
                
                
                
                
                
                }

            }
            else
            {
                    Console.WriteLine("Enter the right pin.");
            }

            







        }



    }
}
