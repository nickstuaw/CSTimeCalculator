using System;

namespace CSTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hours have you worked for?");
            String amount = Console.ReadLine();
            int hours = Int32.Parse(amount);
            int minutes = hours * 60;
            int seconds = minutes * 60;
            Console.WriteLine($"You have been working for {minutes} minutes and {seconds} seconds. ");
        }
    }
}