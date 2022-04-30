using System;
using System.Diagnostics;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Epic();
        }
        static void Epic()
        {
            int numberOfCupOfCoffee = 2; 
            string fullName = "Walrus Autotune";
            DateTime today = DateTime.Now;
            Console.WriteLine($"Aloha, my name is {fullName}. I drink roughly {numberOfCupOfCoffee} cups of coffee a day. Today is {today.DayOfWeek}, it's {today:h:mm tt} now.");

            Console.Write("Please type your name then press enter ->...");
            string userName = Console.ReadLine();
            Console.Write($"En taro adun, {userName}");
        }
    }
}
