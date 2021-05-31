using System;

namespace RandomPasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator();
        }

        public static void PasswordGenerator()
        {
            Console.WriteLine("Welcome to password generator");
            Console.WriteLine("Please enter how much character you would like in your password?");
            var length = Console.ReadLine();
            int passwordLength = Int32.Parse(length);
           
                var password = RandomPassword(passwordLength);
                Console.WriteLine($"{password}");
                Console.ReadKey();
         
           
        }
        public static string RandomPassword(int passwordLength)
        {
           
            string text = "aAbBcCdDeEfFgGhHiIjJhHkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ01234567890123456789,;:!*$@-_=,;:!*$@-_=";
            Random random = new Random();
            char[] chars = new char[passwordLength];
            for(int i = 0; i < passwordLength; i++)
            {
                chars[i] = text[random.Next(0, text.Length)];
            }
            return new string(chars);
        }
    }
}
