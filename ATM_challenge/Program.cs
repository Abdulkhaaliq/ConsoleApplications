using System;

namespace ATM_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourPin = 54106;
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Please enter your your 5 digit pin");
            int pin = Convert.ToInt32(Console.ReadLine());
            if (pin == yourPin)
            {
                AtmMethod();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please re-enter your pin");
                int pin2 = Convert.ToInt32(Console.ReadLine());
                if (pin2 == yourPin)
                {
                    AtmMethod();
                }
            }
        }

        public static void AtmMethod()
        {
            int balance = 4000;
            Console.Clear();
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine();
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Cancel");
            Console.WriteLine();
            Console.WriteLine("Press enter a number:");
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine($"Your balance: {balance}");
                        Console.WriteLine("Press enter to go back...");
                        Console.ReadKey();
                        Console.Clear();
                        AtmMethod();
                        break;
                    }
                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("How much would you like to withdraw?");
                        int Amount = Convert.ToInt32(Console.ReadLine());
                        if(Amount <= balance)
                        {
                            Console.Clear();
                            int newBalace = balance - Amount;
                            Console.WriteLine($"Your new balance is {newBalace}");
                            Console.WriteLine("Press enter to Exit...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Not enough money in your account");
                            Console.WriteLine("Press enter to go back...");
                            Console.ReadKey();
                            AtmMethod();
                        }
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Enjoy your day");
                        break;
                    }
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Press enter to go back...");
                    Console.ReadKey();
                    AtmMethod();
                    break;
            }
        }
    }
}
