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
            Console.WriteLine($"En taro adun, {userName}!");
            
            Console.Write("Please type a number then press enter ->..."); 
            string firstNumberAsString = Console.ReadLine(); 
            Console.Write("Please type another number then press enter ->..."); 
            string secondNumberAsString = Console.ReadLine();

            Double firstOperand = double.Parse(firstNumberAsString);
            Double secondOperand = double.Parse(secondNumberAsString);
            
            
            
        }
    }
}
