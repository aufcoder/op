using System;
namespace variant2
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Write a world to compare for palindrom:\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            Console.ResetColor();
            string reversed = new string(input.Reverse().ToArray());

            if (input.Equals(reversed))
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nYes, Miku <3");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo,Miku(");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
            }
        }
    }
}