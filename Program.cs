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

            Double sum = firstOperand + secondOperand;
            Double difference = firstOperand - secondOperand;
            Double product = firstOperand * secondOperand;
            Double quotient = firstOperand / secondOperand;
            Double remainder = firstOperand % secondOperand;
            Console.WriteLine("\nYou have now been subscribed to useless number facts. Standard data and text messaging rates may apply.\n"); 
            Console.WriteLine("Here are useless facts about your numbers: \n"); 
            Console.WriteLine($"The sum of the two numbers is {sum}.\nThe difference between the numbers is {difference}.\n" +
                          $"The product of the two numbers is {product}.\nWhen the {firstOperand} is divided by the {secondOperand}, the quotient is {quotient}.\nThe remainder is {remainder}." ); 
            
            

        }
    }
}
